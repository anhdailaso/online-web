using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataModel.Dao;

namespace BooShop.Areas.Admin.Controllers
{
    public class HomeController : BaseController
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            UserDao user = new UserDao();
            ViewBag.count_user = user.Usercount();
            return View();
        }
    }
}