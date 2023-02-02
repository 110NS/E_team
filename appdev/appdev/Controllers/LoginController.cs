using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace appdev.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult AdminLogin()
        {
            return View();
        }

        public IActionResult Signup()
        {
            return View();
        }


        public IActionResult StudentLogin()
        {
            return View();
        }
        
        //管理者
        
        public IActionResult Login(string id, string password)
        {
            string test_id = "WizSample01";
            string test_password = "1234";
            Debug.WriteLine(id);
            Debug.WriteLine(password);

            bool isLogin = id == test_id && password == test_password;
            if (isLogin)
            {
                return RedirectToAction("TopPage","Admin");
            }
            
            return View("AdminLogin");
        }
        
        
        //児童用ログイン
        
        public IActionResult Student(string ID, string PASSWORD)
        {
            string test_ID = "WizSample02";
            string test_PASSWORD = "1123";
            Debug.WriteLine(ID);
            Debug.WriteLine(PASSWORD);

            bool IsLogin = ID == test_ID && PASSWORD == test_PASSWORD;
            if (IsLogin)
            {
                //return RedirectToAction("account_management", "Admin");

                //別のページで試したら普通にできました↑

                //問題の箇所↓
                return RedirectToAction("MainchatPage", "Talk");

            }

            return View("StudentLogin");
        }
        
    }
}
