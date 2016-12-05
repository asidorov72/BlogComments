using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BlogComments.Models
{
    public class Comment
    {
        public int Id { get; set;  }

        public string UserId { get; set; }

        public int PostId { get; set; }

        public string Author { get; set; }

        public string CommentTxt { get; set; }

        public DateTime Date { get; set; }

        public Comment()
        {
        }
    }
}