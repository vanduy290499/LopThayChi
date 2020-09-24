using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.DAO;
using Model.EF;
using PagedList;


namespace pinwhell.Areas.Manage.Controllers
{
    public class StudentsController : BaseController
    {
        // GET: Manage/Students
        public StudentDao dao = new StudentDao();
        public PinwhellDbContext db = new PinwhellDbContext();
        public ActionResult Index(int page = 1, int pagesize = 10)
        {

            var model = dao.ListAllSudent(page, pagesize);
            int count = model.Count();
            return View(model);
        }

        //public ActionResult Index(int id,int page = 1 , int pagesize = 10)
        //{
        //    var student = new StudentDao().ViewDetail(id);
        //    int totalRecord = 0;
        //    var model = dao.Listall(id, ref totalRecord, page, pagesize);
        //    return View(model);
        //}
        [HttpGet]
        public ActionResult Create()
        {

            List<MonHoc> listmh = db.MonHoc.ToList();
            ViewBag.listmh = new SelectList(listmh, "MaMH", "TenMH");

            List<HocPhi> listhp = db.HocPhi.ToList();
            ViewBag.listhp = new SelectList(listhp,"MaHP","HocPhi");

            List<TinhTrangHocTap> listht = db.TinhTrangHocTap.ToList();
            ViewBag.listht = new SelectList(listht, "MaTTHT", "TinhTrangHT");

            List<TinhTrangHocPhi> listthp = db.TinhTrangHocPhi.ToList();
            ViewBag.listthp = new SelectList(listthp, "MaTTHP", "TinhTrangHP");
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student st)
        {
            if (ModelState.IsValid)
            {
                long id = dao.Insert(st);
                if (id > 0)
                {
                    return RedirectToAction("Index", "Students");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm Học Sinh Không Thành Công");
                }
            }
            List<MonHoc> listmh = db.MonHoc.ToList();
            ViewBag.listmh = new SelectList(listmh, "MaMH", "TenMH");

            return View("Create");
        }

        [HttpGet]
        public ActionResult CreateMonHoc()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateMonHoc(MonHoc mh)
        {
            if (ModelState.IsValid)
            {
                long id = dao.Insert_MonHoc(mh);
                if (id > 0)
                {
                    return RedirectToAction("ListAllMonHoc", "Students");
                }
                else
                {
                    ModelState.AddModelError("", "Không Thêm Được");
                }
            }
            return View("CreateMonHoc");

        }
        //public ActionResult Edit(int id)
        //{
        //    var student = new StudentDao().ViewDetail(id);
        //    return View(student);
        //}
        [HttpGet]
        public ActionResult Edit(int id )
        {
            var student = new StudentDao().ViewDetail(id);
            List<TinhTrangHocTap> ttht = db.TinhTrangHocTap.ToList();
            ViewBag.ttht = new SelectList(ttht, "MaTTHT", "TinhTrangHT");

            List<TinhTrangHocPhi> tthp = db.TinhTrangHocPhi.ToList();
            ViewBag.tthp = new SelectList(tthp, "MaTTHP", "TinhTrangHP");
            return View(student);
        }
        [HttpPost]
        public ActionResult Edit(Student st)
        {
            var dao = new StudentDao();
            if (ModelState.IsValid)
            {
                var id = dao.Update(st);
                if (id)
                {
                    return RedirectToAction("Index", "Students");
                }
                else
                {
                    ModelState.AddModelError("", "Cập Nhật Học Sinh Không Thành CÔng");
                }
            }
            return View("Edit");
        }

        public ActionResult Delete(int id)
        {
            new StudentDao().Delete(id);
            return RedirectToAction("Index");
        }

    }
}