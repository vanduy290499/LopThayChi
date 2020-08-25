using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


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