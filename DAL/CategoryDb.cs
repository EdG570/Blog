using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;

namespace DAL
{
    public class CategoryDb
    {
        private BlogEntities db;

        public CategoryDb()
        {
            db = new BlogEntities();
        }

        public IEnumerable<Category> GetAll()
        {
            return db.Categories.ToList();
        }

        public Category GetById(int id)
        {
            return db.Categories.Find(id);
        }

        public void Insert(Category cat)
        {
            db.Categories.Add(cat);
            Save();
        }

        public void Delete(int id)
        {
            Category cat = GetById(id);
            db.Categories.Remove(cat);
            Save();
        }

        public void Update(Category cat)
        {
            db.Entry(cat).State = EntityState.Modified;

        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
