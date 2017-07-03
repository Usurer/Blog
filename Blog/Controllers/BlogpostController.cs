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
        public class Context : DbContext
        {

        }

        public ActionResult Add()
        {
            var model = new List<HtmlString>();

            using (var context = new BlogContext())
            {
                var posts = context.Posts.Select(x => x.Text).ToArray();
                model.AddRange(posts.Select(x => new HtmlString(x)));
            }

            return View(model);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Add(string data)
        {
            using (var context = new BlogContext())
            {
                var post = new Post() { Text = data };
                context.Posts.Add(post);
                context.SaveChanges();
            }

            return View();
        }
    }
}