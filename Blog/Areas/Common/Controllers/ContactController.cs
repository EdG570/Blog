using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Areas.Common.Controllers
{
    public class ContactController : Controller
    {
        // GET: Common/Contact
        public ActionResult Index()
        {
            return View();
        }
    }
}