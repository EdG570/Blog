﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Areas.Security.Controllers
{
    public class LogInController : Controller
    {
        // GET: Security/LogIn
        public ActionResult Index()
        {
            return View();
        }
    }
}