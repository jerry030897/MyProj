using MyLoginPage.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyLoginPage.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel pageData)
        {
            if ( !string.IsNullOrWhiteSpace(pageData.Account) && !string.IsNullOrWhiteSpace(pageData.Password))
            {
                List<string> BanList = new List<string> { };
                BanList.Add("skilltree");
                BanList.Add("demo");
                BanList.Add("twMVC");

                foreach (var item in BanList)
                {
                    if (pageData.Account.Contains(item))
                    {
                        pageData.Message = "登入失敗！帳號包含非法字元！";
                        return View(pageData);
                    }
                }

                pageData.Message = $"您使用{pageData.Account}登入成功。";
            }
            return View(pageData);
        }
    }
}