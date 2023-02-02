using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace appdev.Controllers
{
    
    public class TalkController : Controller
    {

        public IActionResult MainchatPage()
        {
            return View("ChatPage");
        }

        public IActionResult fishingpage()
        {
            return View();
        }

    }
    
}
