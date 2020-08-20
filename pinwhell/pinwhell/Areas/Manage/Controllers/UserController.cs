using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pinwhell.Areas.Manage.Controllers
{
    public class UserController : Controller
    {
        // GET: Manage/User
        public ActionResult Index()
        {
            return View();
        }
    }
}