using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class PostViewModel
    {
        public string Title { get; set; }

        public HtmlString Text { get; set; }
    }
}