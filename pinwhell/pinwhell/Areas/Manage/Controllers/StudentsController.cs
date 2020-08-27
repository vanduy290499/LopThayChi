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
    public class StudentsController : Controller
    {
        // GET: Manage/Students
        public StudentDao dao = new StudentDao();
        public PinwhellDbContext db = new PinwhellDbContext();
        public ActionResult Index(int page = 1, int pagesize = 10)
        {
         
            var model = dao.ListAllStudent(page, pagesize);
            int count = model.Count();
            return View(model);
        }
        public ActionResult ListAllMonHoc(int page = 1, int pagesize = 10)
        {
            
            var model = dao.ListAllMonHoc(page, pagesize);
            return View(model);
        }
        
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
    }
}