using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Areas.Common.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Post> posts { get; set; }
        public IEnumerable<Category> categories { get; set; }
        public IEnumerable<Tag> tags { get; set; }
    }
}