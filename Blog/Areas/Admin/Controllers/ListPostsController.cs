using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Areas.Admin.Controllers
{
    public class ListPostsController : Controller
    {
        // GET: Admin/ListPosts
        public ActionResult Index()
        {
            return View();
        }
    }
}