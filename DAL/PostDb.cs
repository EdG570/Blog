using BOL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PostDb
    {
        private BlogEntities db;

        public PostDb()
        {
            db = new BlogEntities();
        }

        public IEnumerable<Post> GetAll()
        {
            return db.Posts.ToList();
        }

        public Post GetById(int id)
        {
            return db.Posts.Find(id);
        }

        public void Insert(Post post)
        {
            db.Posts.Add(post);
            Save();
        }

        public void Delete(int id)
        {
            Post post = GetById(id);
            db.Posts.Remove(post);
            Save();
        }

        public void Update(Post post)
        {
            db.Entry(post).State = EntityState.Modified; 
            Save();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
