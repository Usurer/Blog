using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class NavigationController : Controller
    {
        [ChildActionOnly]
        public PartialViewResult LogOff()
        {
            return PartialView("_LogOff");
        }
    }
}