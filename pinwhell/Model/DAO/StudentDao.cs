using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagedList;
namespace Model.DAO
{
    public class StudentDao
    {
        PinwhellDbContext db = null;
        public StudentDao()
        {
            db = new PinwhellDbContext();
        }
        public IEnumerable<Student> ListAllStudent(int page, int pagesize)
        {
            return db.Student.OrderByDescending(x => x.Lop).ToPagedList(page, pagesize);
        }
        public IEnumerable<MonHoc> ListAllMonHoc(int page, int pagesize)
        {
            return db.MonHoc.OrderBy(x => x.MaMH).ToPagedList(page, pagesize);
        }

    }
}
