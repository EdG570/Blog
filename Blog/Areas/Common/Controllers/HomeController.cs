using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog.Areas.Common.ViewModels;
using BOL;

namespace Blog.Areas.Common.Controllers
{
    public class HomeController : Controller
    {
        private BaseBs db;

        public HomeController()
        {
            db = new BaseBs();
        }

        // GET: Common/Home
        public ActionResult Index(string categoryId, string tagId)
        {
            var catId = Convert.ToInt32(categoryId);
            var tId = Convert.ToInt32(tagId);
            HomeViewModel vm = new HomeViewModel();

            if ( catId > 0)
            {
                vm.posts = db.postBs.GetAll().Where(x => (x.IsPublished == true) && (x.CategoryId == catId)).Take(5).OrderByDescending(x => x.Created_At);
            }
            else
            {
                vm.posts = db.postBs.GetAll().Where(x => x.IsPublished == true).Take(5);
            }

            vm.categories = db.categoryBs.GetAll().OrderBy(x => x.Name);
            vm.tags = db.tagBs.GetAll().OrderBy(x => x.Name);

            return View(vm);
        }
    }
}