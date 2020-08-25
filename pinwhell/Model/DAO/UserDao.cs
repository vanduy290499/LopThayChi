using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagedList;

namespace Model.DAO
{
    public class UserDao
    {
        PinwhellDbContext db = null;
        public UserDao()
        {
            db = new PinwhellDbContext();
        }
        public IEnumerable<TaiKhoan> ListAllPaging(int page, int pageSize)
        {
            return db.TaiKhoan.ToPagedList(page, pageSize);
        }
    }
}
