using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagedList;
//using Model.ViewModel;
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
        //public List<StudentList> Listall(int pagesize, ref int totalRecord, int id, int pageIndex = 1)
        //{
        //    totalRecord = db.Student.Where(x => x.MaHS == id).Count();
        //    var model = (from a in db.Student
        //                join b in db.TinhTrangHocTap on a.MaHS equals b.MaTTHT
        //                join c in db.TinhTrangHocPhi on a.MaHS equals c.MaTTHP
        //                join d in db.MonHoc on a.MaHS equals d.MaMH
        //                join e in db.HocPhi on a.MaHS equals e.MaHP
        //                where a.MaHS == id
        //                select new StudentList()
        //                {
        //                    MaHS = a.MaHS,
        //                    TenHS = a.HoTenHS,
        //                    TenPH = a.HoTenPH,
        //                    MonHoc = d.TenMH,
        //                    Lop = a.Lop,
        //                    HocPhi = a.HocPhi,
        //                    NgayDangKi = a.NgayDangKi,
        //                    NgayBatDauHoc = a.NgayBatDauHoc,
        //                    TinhTranHocTap = b.TinhTrangHT,
        //                    TinhTrangHocPhi = c.Tinhtranghp,
        //                    LoiNhac = a.LoiNhac,
        //                    Status = a.Status
        //                });
        //    model.OrderByDescending(x => x.Lop).Skip((pageIndex - 1) * pagesize).Take(pagesize);
        //    return model.ToList();
        //}

        public IEnumerable<Student> ListAllSudent(int page, int pagesize)
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
                student.Lop = entity.Lop;
                student.NgayDongHocPhi = entity.NgayDongHocPhi;
                student.TinhTrangHP = entity.TinhTrangHP;
                student.TinhTrangHT = entity.TinhTrangHT;
                student.LoiNhac = entity.LoiNhac;
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
