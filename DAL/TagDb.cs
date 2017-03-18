using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;

namespace DAL
{
    public class TagDb
    {
        private BlogEntities db;

        public TagDb()
        {
            db = new BlogEntities();
        }

        public IEnumerable<Tag> GetAll()
        {
            return db.Tags.ToList();
        }

        public Tag GetById(int id)
        {
            return db.Tags.Find(id);
        }

        public void Insert(Tag tag)
        {
            db.Tags.Add(tag);
            Save();
        }

        public void Delete(int id)
        {
            Tag tag = GetById(id);
            db.Tags.Remove(tag);
            Save();
        }

        public void Update(Tag tag)
        {
            db.Entry(tag).State = EntityState.Modified;
            Save();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
