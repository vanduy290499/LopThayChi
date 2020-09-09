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
        public long Insert(Student entity)
        {
            db.Student.Add(entity);
            db.SaveChanges();
            return entity.MaHS;
        }
        public bool Delete(int id)
        {
            try
            {
                var xoa = db.Student.Find(id);
                db.Student.Remove(xoa);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public long Insert_MonHoc(MonHoc entity)
        {
            db.MonHoc.Add(entity);
            db.SaveChanges();
            return entity.MaMH;
        }
        public IEnumerable<Student> ListAllStudent(int page, int pagesize)
        {
            return db.Student.OrderBy(x => x.Lop).ToPagedList(page, pagesize);
        }
        public IEnumerable<MonHoc> ListAllMonHoc(int page, int pagesize)
        {
            return db.MonHoc.OrderBy(x => x.MaMH).ToPagedList(page, pagesize);
        }
        public Student ViewDetail(int id)
        {
            return db.Student.Find(id);
        }
        public bool Update(Student entity)
        {
            try
            {
                var student = db.Student.Find(entity.MaHS);
                student.HoTenHS = entity.HoTenHS;
                student.HoTenPH = entity.HoTenPH;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
