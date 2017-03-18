using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BaseBs
    {
        public CategoryBs categoryBs { get; set; }
        public PostBs postBs { get; set; }
        public TagBs tagBs { get; set; }

        public BaseBs()
        {
            categoryBs = new CategoryBs();
            postBs = new PostBs();
            tagBs = new TagBs();
        }
    }
}
