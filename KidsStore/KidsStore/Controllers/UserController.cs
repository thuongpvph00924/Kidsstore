using KidsStore.Common;
using KidsStore.Model.DAO;
using KidsStore.Model.EF;
using KidsStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidsStore.Controllers
{
    
    public class UserController: Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                var res = dao.Login(model.UserName, model.Password);
                if (res)
                {
                    var user = dao.GetByID(model.UserName);
                    var userSession = new UserLogin();
                    userSession.UserName = user.UserName;
                    userSession.UserID = user.ID;
                    Session.Add(CommonConstanst.USER_SESSION, userSession);
                    return Redirect("/");
                }
                else
                {
                    ModelState.AddModelError("", "Tài Khoản không tồn tại.");
                }
            }
            return View(model);
        }
        public ActionResult Register()
        {
            return View();
        }
       [HttpPost]
        public ActionResult Register(RegisterModel model)
        {
            if(ModelState.IsValid)
            {
                var dao = new UserDao();

                if(dao.CheckUserName(model.Name))
                {
                    ModelState.AddModelError("", "Tài khoản đã tồn tại");
                }
                else
                {
                    var user = new User();
                    user.UserName = model.Name;
                    user.Password = model.Password;
                   
              var result=dao.Insert(user);
                    if(result>0)
                    {
                        ViewBag.Success = "Đăng ký thành công.";
                        model = new RegisterModel();

                    }
                    else
                    {
                        ModelState.AddModelError("", "Đăng ký không thành công.");
                    }
                }
            }
            return View(model);
        }
        public ActionResult Logout()
        {
            Session[CommonConstanst.USER_SESSION] = null;
            return Redirect("/");
        }

    
    }
}