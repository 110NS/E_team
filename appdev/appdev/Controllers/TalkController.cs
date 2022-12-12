using Microsoft.AspNetCore.Mvc;

namespace appdev.Controllers
{
    public class TalkController : Controller
    {
        public IActionResult MainchatPage()
        {
            return View();
        }
    }
}
