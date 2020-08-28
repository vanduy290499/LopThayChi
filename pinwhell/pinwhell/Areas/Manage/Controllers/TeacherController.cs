using Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.EF;

namespace pinwhell.Areas.Manage.Controllers
{
    public class TeacherController : Controller
    {
        public TeacherDao dao = new TeacherDao();
        public PinwhellDbContext db = new PinwhellDbContext();

        // GET: Manage/Teacher
        public ActionResult Index(int page = 1, int pageSize=10)
        {
            var model = dao.ListAllTeacherPaging(page, pageSize);
            return View(model);
        }
        public ActionResult TaiLieuHocTap(int page = 1, int pageSize = 10)
        {
            var model = dao.ListAllTaiLieupaging(page, pageSize);
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Teacher ta)
        {
            if (ModelState.IsValid)
            {
                long id = dao.Insert(ta);
                if (id > 0)
                {
                    return RedirectToAction("Index", "Teacher");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm Giáo Viên Không Thành Công");
                }
            }
            return View("Create");

        }
    }
}