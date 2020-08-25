using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.DAO;
using PagedList;


namespace pinwhell.Areas.Manage.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Manage/Students
        public ActionResult Index(int page = 1, int pagesize = 10)
        {
            var dao = new StudentDao();
            var model = dao.ListAllStudent(page, pagesize);
            return View(model);
        }
        public ActionResult ListAllMonHoc(int page = 1, int pagesize = 10)
        {
            var dao = new StudentDao();
            var model = dao.ListAllMonHoc(page, pagesize);
            return View(model);
        }
    }
}