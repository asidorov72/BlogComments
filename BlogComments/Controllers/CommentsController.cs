using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using BlogComments.Models;
using Microsoft.AspNet.Identity;
using System.Web.Script.Serialization;


namespace BlogComments.Controllers
{
    public class CommentsController : Controller
    {
        BlogContext db = new BlogContext();
        public List<object> commentsToView { get; set; }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Add(int? id, int Postid)
        {
            string UserId = null;
            UserId = User.Identity.GetUserId();
            ViewBag.UserId = UserId;
            ViewBag.PostId = Postid;
            return View();
        }

        // GET: Posts/Create
        [HttpPost]
        public ActionResult Add(Comment comment)
        {
            comment.Date = DateTime.Now;
            db.Comments.Add(comment);
            db.SaveChanges();

            ViewBag.Message = "New comment was created! Thanks, mate!";
            return RedirectToAction("Blog", "Home");
        }


        [HttpPost]
        public ActionResult AddAjaxComment(Comment comment)
        {
            if (comment == null)
            {
                return HttpNotFound();
            }

            string UserId = null;
            string UserName = null;
            if (User.Identity.IsAuthenticated)
            {
                UserName = User.Identity.Name;
                UserId = User.Identity.GetUserId();
            }
            else
            {
                UserName = comment.Author;
            }

            comment.Date = DateTime.Now;
            comment.Author = UserName;
            db.Comments.Add(comment);
            db.SaveChanges();

            ViewBag.postId = comment.PostId;
            var CommentsList = db.Comments.Where(c => c.PostId == comment.PostId).OrderByDescending(c => c.Date).ToList();
            ViewBag.Comments = CommentsList;
            ViewBag.CommentsCount = CommentsList.Count();

            return PartialView("_AddAjaxComment");
        }




  

    }
}