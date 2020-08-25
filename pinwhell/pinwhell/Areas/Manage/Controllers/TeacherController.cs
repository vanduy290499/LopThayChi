using Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pinwhell.Areas.Manage.Controllers
{
    public class TeacherController : Controller
    {
        public TeacherDao db = new TeacherDao();
        // GET: Manage/Teacher
        public ActionResult Index(int page = 1, int pageSize=10)
        {
            var model = db.ListAllTeacherPaging(page, pageSize);
            return View(model);
        }
        public ActionResult TaiLieuHocTap(int page = 1, int pageSize = 10)
        {
            var model = db.ListAllTaiLieupaging(page, pageSize);
            return View(model);
        }
    }
}