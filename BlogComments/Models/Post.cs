using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BlogComments.Models
{
    public class Post
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public string Title { get; set; }

        public string PostTxt { get; set; }
        
        public DateTime Date { get; set; }

        public Post()
        {
        }
    }
}