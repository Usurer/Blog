using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog.Data;
using Blog.Models;

namespace Blog.Controllers
{
    public class StartPageController : Controller
    {
        public ActionResult Posts()
        {
            var posts = MvcApplication
                .DbContext
                .Posts
                .ToArray()
                .Select(x => new PostViewModel() { Text = new HtmlString(x.Text) } )
                .ToList();

            return View(posts);
        }
    }
}