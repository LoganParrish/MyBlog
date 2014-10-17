using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyBlog.Models;

namespace MyBlog.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        BlogEntities db = new BlogEntities();
        [HttpGet]
        public ActionResult Index()
        {
            return View(db.Posts.OrderByDescending(x => x.DateCreate));
        }

        public ActionResult AddComment(Models.Comment commentToAdd)
        {
            commentToAdd.DateCreate = DateTime.Now;

            //add comment to db
            db.Comments.Add(commentToAdd);
            db.SaveChanges();

            //replace with AJAX
            //return RedirectToAction("Index", "Home");
            return PartialView("Comment", commentToAdd);

        }
        public ActionResult LikePost(int id)
        {
            Post postToLike = db.Posts.Find(id);
            if (postToLike.Likes == null)
            {
                postToLike.Likes = 0;
            }
            postToLike.Likes++;
            db.SaveChanges();
            return Content(postToLike.Likes + " Likes");
        }
    }
}
