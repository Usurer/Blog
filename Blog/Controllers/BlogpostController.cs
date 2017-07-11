using Blog.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class BlogpostController : Controller
    {
        public ActionResult Add()
        {
            var model = GetPosts();
            return View(model);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Add(string data)
        {
            var post = new Post()
            {
                Text = data
            };

            MvcApplication.DbContext.Posts.Add(post);
            MvcApplication.DbContext.SaveChanges();

            var model = GetPosts();

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