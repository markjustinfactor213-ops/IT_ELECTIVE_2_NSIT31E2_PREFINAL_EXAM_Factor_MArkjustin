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
                new QuestionItem { Id = 2, Question = "Which approach is being used when an existing database is used to generate EF Core entity classes?", Options = new List<string>{ "A. Code-First", "B. Database-First", "C. Model-First", "D. Controller-First" }, CorrectAnswer = "B. Database-First", Explanation = "Database-First scaffolding generates code entities directly from an existing database schema." },
                new QuestionItem { Id = 3, Question = "What is the primary purpose of Entity Framework Core?", Options = new List<string>{ "A. To create HTML pages automatically", "B. To replace the MVC Controller", "C. To map objects in code to relational database data", "D. To replace the C# compiler" }, CorrectAnswer = "C. To map objects in code to relational database data", Explanation = "EF Core acts as an Object-Relational Mapper (ORM) bridging .NET objects with relational databases." },
            };

            return View(examQuestions);
        }
    }
}