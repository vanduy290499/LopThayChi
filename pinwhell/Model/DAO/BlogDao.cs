using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;
using PagedList;
using PagedList.Mvc;

namespace Model.DAO
{
    public class BlogDao
    {
        PinwhellDbContext db = null;
        public BlogDao()
        {
            db = new PinwhellDbContext();
        }
        public long Insert(Blog entity)
        {
            db.Blog.Add(entity);
            db.SaveChanges();
            return entity.MaBL;
        }
        public IEnumerable<Blog> ListAll(int page, int pagesize)
        {
            return db.Blog.OrderBy(x => x.MaBL).ToPagedList(page, pagesize);
        }
    }
}
