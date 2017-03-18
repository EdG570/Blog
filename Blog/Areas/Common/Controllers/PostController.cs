using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;

namespace Blog.Areas.Common.Controllers
{
    public class PostController : Controller
    {
        private BaseBs db;

        public PostController()
        {
            db = new BaseBs();
        }
        // GET: Common/Post
        public ActionResult Index(int id)
        {
            var post = db.postBs.GetById(id);
            return View(post);
        }
    }
}