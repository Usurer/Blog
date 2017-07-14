using Blog.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Blog
{
    public class MvcApplication : HttpApplication
    {
        public static BlogContext DbContext { get; private set; }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        public override void Init()
        {
            BeginRequest += MvcApplication_BeginRequest;
            EndRequest += MvcApplication_EndRequest;
        }

        private void MvcApplication_BeginRequest(object sender, EventArgs e)
        {
            DbContext = new BlogContext();
            Database.SetInitializer<BlogContext>(null);
        }

        private void MvcApplication_EndRequest(object sender, EventArgs e)
        {
            DbContext.Dispose();
        }

    }
}
