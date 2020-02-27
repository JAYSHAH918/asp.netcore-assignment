using System;
using System.Linq;
using System.Threading.Tasks;
using CommentAssignment.Models;
using PusherServer;
using System.Web.Mvc;

namespace CommentAssignment.Controllers
{
    public class HomeController
    {
        Models.BlogPosts.ApplicationDbContext db = new Models.BlogPosts.ApplicationDbContext();

        public System.Web.Mvc.ActionResult Index()
        {
            return View(db.BlogPosts);
        }

        private System.Web.Mvc.ActionResult View(object p)
        {
            throw new NotImplementedException();
        }

        public System.Web.Mvc.ActionResult Create()
        {
            return View();
        }

        private System.Web.Mvc.ActionResult View()
        {
            throw new NotImplementedException();
        }

        [System.Web.Mvc.HttpPost]
        public System.Web.Mvc.ActionResult Create(BlogPosts post)
        {
            object p = db.BlogPosts.Add(post);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        private System.Web.Mvc.ActionResult RedirectToAction(string v)
        {
            throw new NotImplementedException();
        }

        public System.Web.Mvc.ActionResult Details(int? id)
        {
            return View(db.BlogPosts.Find(id));
        }

        public System.Web.Mvc.ActionResult Comments(int? id)
        {
            var comments = db.Comment.Where(x => x.BlogPostID == id).ToArray();
            return Json(comments, JsonRequestBehavior.AllowGet);
        }

        private System.Web.Mvc.ActionResult Json(object comments, object allowGet)
        {
            throw new NotImplementedException();
        }

        [System.Web.Mvc.HttpPost]
        public async Task<System.Web.Mvc.ActionResult> Comment(Comment data)
        {
             db.Comment.Add(data);
            db.SaveChanges();
            var options = new PusherOptions();
            options.Cluster = "XXX_APP_CLUSTER";
            var pusher = new Pusher("XXX_APP_ID", "XXX_APP_KEY", "XXX_APP_SECRET", options);
            ITriggerResult result = await pusher.TriggerAsync("asp_channel", "asp_event", data);
            return Content("ok");
        }

        private System.Web.Mvc.ActionResult Content(string v)
        {
            throw new NotImplementedException();
        }
    }
}
