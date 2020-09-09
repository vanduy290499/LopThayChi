using Model.DAO;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
        public ActionResult Create(Teacher tc)
        {
            if (ModelState.IsValid)
            {
                long id = dao.Insert(tc);
                if (id > 0)
                {
                    return RedirectToAction("Index", "Teacher");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm giáo viên không thành công");
                }
            }
            return View("Create");
        }
       
        public ActionResult Delete(int id)
        {
            var teacher = new TeacherDao().Delete(id);
            return RedirectToAction("Index");

        }
        public ActionResult Edit(int id)
        {
            var teacher = new TeacherDao().ViewDetail(id);
            return View(teacher);
        }
        [HttpPost]
        public ActionResult Edit(Teacher ta)
        {
            var dao = new TeacherDao();
            if (ModelState.IsValid)
            {
                var id = dao.Update(ta);
                if (id)
                {
                    return RedirectToAction("Index", "Teacher");
                }
                else
                {
                    ModelState.AddModelError("", "Cập Nhật giáo viên Không Thành Công");
                }
            }
            return View("Edit");
        }
    }
}