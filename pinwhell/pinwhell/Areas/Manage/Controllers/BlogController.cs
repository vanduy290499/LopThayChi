using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.DAO;
using Model.EF;
using PagedList;
using PagedList.Mvc;

namespace pinwhell.Areas.Manage.Controllers
{
    public class BlogController : Controller
    {
        // GET: Manage/Blog
        public BlogDao dao = new BlogDao();
        public PinwhellDbContext db = new PinwhellDbContext();
        public ActionResult Index(int page = 1, int pagesize = 10)
        {
            var model = dao.ListAll(page, pagesize);
            return View(model);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Blog bl)
        {
            if (ModelState.IsValid)
            {
                long id = dao.Insert(bl);
                if(id > 0)
                {
                    return RedirectToAction("Index", "Blog");
                }
                else
                {
                     ModelState.AddModelError("", "Thêm bài viết không thành công");
                }
               
            }
            return View("Create");
        }
    }
}