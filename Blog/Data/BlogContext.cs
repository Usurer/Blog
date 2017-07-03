﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Blog.Data
{
    public class BlogContext : DbContext
    {
        public BlogContext() : base("name=DefaultConnection") { }

        public DbSet<Post> Posts { get; set; }
    }
}