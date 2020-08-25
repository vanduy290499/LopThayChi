using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagedList;

namespace Model.DAO
{
    public class TeacherDao
    {
        PinwhellDbContext db = null;
        public TeacherDao()
        {
            db = new PinwhellDbContext();
        }
        public IEnumerable<Teacher> ListAllTeacherPaging(int page, int pageSize)
        {
            return db.Teacher.OrderBy(x => x.MaGV).ToPagedList(page, pageSize);
        }
        public IEnumerable<TaiLieuHocTap> ListAllTaiLieupaging(int page, int pageSize)
        {
            return db.TaiLieuHocTap.OrderByDescending(x => x.MaTL).ToPagedList(page, pageSize);
        }
    }
}
