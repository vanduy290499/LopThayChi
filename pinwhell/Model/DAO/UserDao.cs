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
            return db.TaiKhoan.OrderBy(x => x.NgayTao).ToPagedList(page, pageSize);
        }


        public TaiKhoan GetById(string userName)
        {
            return db.TaiKhoan.SingleOrDefault(x => x.Username == userName);
        }
        public bool Login(string userName, string passWord)
        {
            var result = db.TaiKhoan.Count(x => x.Username == userName && x.Password == passWord);
            if (result > 0)
            {
                return true;
            }
            return false;
        }
    }
}
