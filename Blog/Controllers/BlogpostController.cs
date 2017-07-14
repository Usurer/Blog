using Blog.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    [Authorize]
    public class BlogpostController : Controller
    {
        public ActionResult Add()
        {
            var model = GetPosts();
            return View(model);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Add(string title, string data)
        {
            if (string.IsNullOrWhiteSpace(data) || string.IsNullOrWhiteSpace(title))
            {
                return View("Error");
            }
            
            var post = new Post()
            {
                Title = title,
                Text = data,
                Created = DateTime.Now,
                LastChanged = DateTime.Now,
            };

            MvcApplication.DbContext.Posts.Add(post);
            MvcApplication.DbContext.SaveChanges();

            return RedirectToAction("Add");
        }

        private List<HtmlString> GetPosts()
        {
            return MvcApplication
                .DbContext
                .Posts
                .Select(x => x.Text)
                .ToArray()
                .Select(x => new HtmlString(x))
                .ToList();
        }
    }
}