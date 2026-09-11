using Microsoft.AspNetCore.Mvc;
using IT_ELECTIVE_2_PREFINAL_EXAM.Models;

namespace IT_ELECTIVE_2_PREFINAL_EXAM.Controllers
{
    public class ExamController : Controller
    {
        public IActionResult Index()
        {
            var examQuestions = new List<QuestionItem>
            {
                new QuestionItem { Id = 1, Question = "What is the main problem solved by using a database instead of an in-memory collection?", Options = new List<string>{ "A. It makes C# code shorter", "B. It prevents the application from restarting", "C. It allows data to persist after the application stops", "D. It removes the need for MVC" }, CorrectAnswer = "C. It allows data to persist after the application stops", Explanation = "Databases provide persistent storage, retaining data even after the application process terminates." },
            };

            return View(examQuestions);
        }
    }
}