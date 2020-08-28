using Model.DAO;
using pinwhell.Areas.Manage.Models;
using pinwhell.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pinwhell.Areas.Manage.Controllers
{
    public class LoginController : Controller
    {
        // GET: Manage/Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                var result = dao.Login(model.UserName, model.PassWord);
                if (result)
                {
                    var user = dao.GetById(model.UserName);
                    var userSession = new UserLogin();
                    userSession.UserName = user.Username;
                    userSession.UserID = user.MaTK;
                    Session.Add(CommonConstants.USER_SESSION, userSession);
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Đăng nhập không đúng!");
            }
            return View("Index");
        }
    }
}