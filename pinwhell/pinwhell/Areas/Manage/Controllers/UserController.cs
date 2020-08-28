using Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

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
    }
}