using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogComments.Models;
using System.IO;
using Microsoft.AspNet.Identity;

namespace BlogComments.Controllers
{
    public class HomeController : Controller
    {
        BlogContext db = new BlogContext();

        public ActionResult Index()
        {

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Blog()
        {
            //string UserId = null;
            //UserId = User.Identity.GetUserId();
            //ViewBag.UserId = UserId;


            string UserId = null;
            string UserName = null;
            if (User.Identity.IsAuthenticated)
            {
                UserName = User.Identity.Name;
                UserId = User.Identity.GetUserId();
            }

            ViewBag.UserId = UserId;
            ViewBag.Author = UserName;

            IEnumerable<Post> posts = db.Posts;
            IEnumerable<Comment> comments = db.Comments;

            ViewBag.Posts = posts.OrderByDescending(p => p.Date).ToList();
            ViewBag.Comments = comments.OrderByDescending(c => c.Date).ToList();

           

            /*
            var lastCommentRow = db.Comments.SqlQuery(
                    "SELECT top 1 c.* FROM dbo.Comments c ORDER BY c.Id DESC"
                ).ToList();
            ViewBag.LastComment = lastCommentRow;
            */


            ViewBag.Message = "Your posts should be here";

            return View();
        }
    }
}