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

        public IActionResult Login(string id, string password)
        {
            string test_id = "佐藤";
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
    }
}
