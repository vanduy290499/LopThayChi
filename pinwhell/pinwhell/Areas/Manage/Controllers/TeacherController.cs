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
        // GET: Manage/Teacher
        public TeacherDao dao = new TeacherDao();
        public ActionResult Index(int page = 1, int pageSize = 10)
        { 
            var model = dao.ListAllPaging(page, pageSize);
            return View(model);
        }
        public ActionResult TaiLieuHocTap(int page = 1, int pageSize = 10)
        {

            var model = dao.ListAllTaiLieuPaging(page, pageSize);
            return View(model);
        }
    }
}