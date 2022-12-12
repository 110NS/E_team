using appdev.Models;
using Microsoft.AspNetCore.Mvc;

namespace appdev.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult TopPage()
        {
            QAnswerText m1 = new QAnswerText();
            m1.text = "こんにちは";
            m1.student_name = "たかし";

            QAnswerText m2 = new QAnswerText();
            m2.text = "おつかれ";
            m2.student_name = "ひろき";

            QAnswerStudents list1 = new QAnswerStudents();
            list1.list.Add(m1);
            list1.list.Add(m2);

            QAnswerText m3 = new QAnswerText();
            m3.text = "2こんにちは";
            m3.student_name = "2たかし";

            QAnswerStudents list2 = new QAnswerStudents();
            list2.list.Add(m3);
            

            Questions alllist = new Questions();
            alllist.list_per_q.Add(list1);
            alllist.list_per_q.Add(list2);


            return View(alllist);

            

        }
        public IActionResult account_management()
        {
            return View();
        }
    }
}
