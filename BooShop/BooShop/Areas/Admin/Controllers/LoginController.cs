using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BooShop.Areas.Admin.Models;
using BooShop.Common;
using DataModel.Dao;

namespace BooShop.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(LoginModel enitity)
        {
            if(ModelState.IsValid)
            {
                UserDao user = new UserDao();
                var result = user.Login(enitity.UserName,Encryptor.MD5Hash(enitity.PassWord));
                if (result == 1)
                {
                    var userseson = user.GetUser(enitity.UserName);
                    UserLogin userlogin = new UserLogin();
                    userlogin.UserID = userseson.ID;
                    userlogin.UserName = userseson.UserName;
                    Session.Add(Common.Constant.USER_SESSION, userlogin);
                    return RedirectToAction("Index", "Home");
                }
                else
                if (result == 0)
                {
                    ModelState.AddModelError("", "Đăng nhập không đúng xin vui lòng thử lại.");
                }
                else
                {
                    ModelState.AddModelError("","Tài khoảng này đã bị khóa.");
                }
            }
            return View("Index");
        }
    }
}