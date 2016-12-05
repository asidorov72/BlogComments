using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace BlogComments.Models
{
    public class BlogContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public BlogContext() : base("BlogSystemConnection")
        {

        }

        public static BlogContext Create()
        {
            return new BlogContext();
        }
    }

}