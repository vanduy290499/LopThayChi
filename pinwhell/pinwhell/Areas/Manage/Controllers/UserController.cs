using Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using Model.EF;

namespace pinwhell.Areas.Manage.Controllers
{
    public class UserController : Controller
    {
        // GET: Manage/User
        public ActionResult Index(int page = 1, int pageSize = 10)
        {
            var dao = new UserDao();
            var model = dao.ListAllPaging(page, pageSize);
            return View(model);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Create(TaiKhoan user)
        {
            var dao = new UserDao();
            if (ModelState.IsValid)
            {
                long id = dao.Insert(user);
                if (id > 0)
                {
                    return RedirectToAction("Index", "User");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm User Không Thành Công");
                }
            }
            return View("Create");
        }

        public ActionResult Delete(int id)
        {
            var User = new UserDao().Deleted(id);
            return RedirectToAction("Index");

        }
        public ActionResult Edit(int id)
        {
            var user = new UserDao().ViewDetail(id);
            return View(user);
        }
        [HttpPost]
        public ActionResult Edit(TaiKhoan user)
        {
            var dao = new UserDao();
            if (ModelState.IsValid)
            {
                var id = dao.Update(user);
                if (id)
                {
                    return RedirectToAction("Index", "User");
                }
                else
                {
                    ModelState.AddModelError("", "Cập Nhật User Không Thành Công");
                }
            }
            return View("Update");
        }
    }
}