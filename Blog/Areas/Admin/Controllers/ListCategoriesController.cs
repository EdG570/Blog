using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Areas.Admin.Controllers
{
    public class ListCategoriesController : Controller
    {
        // GET: Admin/ListCategories
        public ActionResult Index()
        {
            return View();
        }
    }
}