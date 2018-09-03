using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataModel.Dao;

namespace BooShop.Areas.Admin.Controllers
{
    public class UserController : BaseController
    {
        // GET: Admin/User
        public ActionResult Index(int page =1, int pagesize =10)
        {
            UserDao user = new UserDao();
            var us = user.GetListUser(page,pagesize);
            return View(us);
        }
        public ActionResult CapNhatNguoiDung(int id)
        {
            return PartialView("_CapNhatNguoiDung.cshtml");
        }
    }
}