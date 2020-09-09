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
        public long Insert(Teacher entity)
        {
            db.Teacher.Add(entity);
            db.SaveChanges();
            return entity.MaGV;
        }
        public bool Delete(int id)
        {
            try
            {
                var xoa = db.Teacher.Find(id);
                db.Teacher.Remove(xoa);
                db.SaveChanges();
                return true;
            }
            catch(Exception)
            {
                return false;
            }

        }
        public bool Update(Teacher entity)
        {
            try
            {
                var teacher = db.Teacher.Find(entity.MaGV);
                teacher.TenGV = entity.TenGV;
                teacher.sdt = entity.sdt;
                teacher.Fb = entity.Fb;
                teacher.DiaChi = entity.DiaChi;
                teacher.email = entity.email;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Teacher ViewDetail(int id)
        {
            return db.Teacher.Find(id);
        }
    }
}
