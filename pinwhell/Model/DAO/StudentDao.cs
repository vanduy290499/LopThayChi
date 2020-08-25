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
        public int Insert (Student entity)
        {
            db.Student.Add(entity);
            db.SaveChanges();
            return entity.MaHS;
        }
        public bool Delete(int id)
        {
            var xoa = db.Student.Find(id);
            db.Student.Remove(xoa);
            db.SaveChanges();
            return true;

        }
        public bool update(Student entity)
        {
            try
            {
                var student = db.Student.Find(entity.MaHS);
                student.TinhTrangHocTap = entity.TinhTrangHocTap;
                student.TinhTrangHocPhi = entity.TinhTrangHocPhi;
                student.Lop = entity.Lop;
                student.LoiNhac = entity.LoiNhac;
                student.NgayDongHocPhi = entity.NgayDongHocPhi;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public IEnumerable<Student> DanhSachStudent(int page, int pagesize, String Search="")
        {
            var list = db.Student.Where(x => x.HoTenHS.Contains(Search)).OrderBy(x => x.Lop).ThenBy(x => x.MaHS).ToPagedList(page, pagesize);
            return list;
        }
        
        public Student ViewDetail(int id )
        {
            return db.Student.Find(id);
        }

    }
}
