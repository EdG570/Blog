using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BOL;

namespace BLL
{
    public class TagBs
    {
        private TagDb db;

        public TagBs()
        {
            db = new TagDb();
        }

        public IEnumerable<Tag> GetAll()
        {
            return db.GetAll();
        }

        public Tag GetById(int id)
        {
            return db.GetById(id);
        }

        public void Insert(Tag tag)
        {
            db.Insert(tag);
        }

        public void Delete(int id)
        {
            db.Delete(id);
        }

        public void Update(Tag tag)
        {
            db.Update(tag);
        }
    }
}
