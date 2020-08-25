using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;
using PagedList;

namespace Model.DAO
{
    class StudentDao
    {
        PinwhellDbContext db = null;
        public StudentDao()
        {
            db = new PinwhellDbContext();
        }
        public IEnumerable<Student> DanhSachStudent(int page, int pagesize, String Search="")
        {
            var list = db.Student.Where(x => x.HoTenHS.Contains(Search)).OrderBy(x => x.Lop).ThenBy(x => x.MaHS).ToPagedList(page, pagesize);
            return list;
        }


    }
}
