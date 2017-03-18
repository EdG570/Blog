using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BOL;

namespace BLL
{
    public class PostBs
    {
        private PostDb db;

        public PostBs()
        {
            db = new PostDb();
        }

        public IEnumerable<Post> GetAll()
        {
            return db.GetAll();
        }

        public Post GetById(int id)
        {
            return db.GetById(id);
        }

        public void Insert(Post post)
        {
            db.Insert(post);
        }

        public void Delete(int id)
        {
            db.Delete(id);
        }

        public void Update(Post post)
        {
            db.Update(post);
        }
    }
}
