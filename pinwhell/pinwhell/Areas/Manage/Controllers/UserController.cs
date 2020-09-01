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
        public ActionResult Index(int page= 1, int pageSize =10)
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
        
        public ActionResult Create(TaiKhoan tk )
        {
            var dao = new UserDao();
            if (ModelState.IsValid)
            {
                long id = dao.Insert(tk);
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
    }
}