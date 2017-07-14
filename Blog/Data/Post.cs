using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog.Data
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        public string Text { get; set; }

        public DateTime Created { get; set; }

        public DateTime LastChanged { get; set; }
    }
}