using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.EF;
using Model.DAO;


namespace pinwhell.Areas.Manage.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Manage/Students
        public ActionResult Index()
        {

            return View();
        }
    }
}