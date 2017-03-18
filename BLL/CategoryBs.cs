using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BOL;

namespace BLL
{
    public class CategoryBs
    {
        private CategoryDb db;

        public CategoryBs()
        {
            db = new CategoryDb();
        }

        public IEnumerable<Category> GetAll()
        {
            return db.GetAll();
        }

        public Category GetById(int id)
        {
            return db.GetById(id);
        }

        public void Insert(Category cat)
        {
            db.Insert(cat);
        }

        public void Delete(int id)
        {
            db.Delete(id);
        }

        public void Update(Category cat)
        {
            db.Update(cat);

        }
    }
}
