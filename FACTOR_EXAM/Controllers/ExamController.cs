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
                new QuestionItem { Id = 4, Question = "Which EF Core component is primarily responsible for communicating with the database?", Options = new List<string>{ "A. DbContext", "B. DbSetView", "C. ControllerContext", "D. RazorContext" }, CorrectAnswer = "A. DbContext", Explanation = "DbContext manages database connections, transactions, and querying." },
                new QuestionItem { Id = 5, Question = "What does the command 'dotnet ef dbcontext scaffold' primarily do?", Options = new List<string>{ "A. Deletes the database", "B. Creates a new MVC project", "C. Generates EF Core models and a DbContext from an existing database", "D. Starts the MVC application" }, CorrectAnswer = "C. Generates EF Core models and a DbContext from an existing database", Explanation = "Scaffolding creates reverse-engineered entity classes and DbContext configuration from an existing database." },
                new QuestionItem { Id = 6, Question = "Where is a database connection string commonly stored in an ASP.NET Core MVC application?", Options = new List<string>{ "A. Program.cs only", "B. appsettings.json", "C. Index.cshtml", "D. Student.cs" }, CorrectAnswer = "B. appsettings.json", Explanation = "appsettings.json stores application configuration settings like database connection strings." },
                new QuestionItem { Id = 7, Question = "A Student belongs to exactly one Section, while a Section can contain many students. What type of relationship is this?", Options = new List<string>{ "A. One-to-One", "B. One-to-Many", "C. Many-to-Many", "D. Many-to-One only" }, CorrectAnswer = "B. One-to-Many", Explanation = "A single section parent record links to multiple student child records." },                new QuestionItem { Id = 8, Question = "In the provided example, what is SectionId?", Options = new List<string>{ "A. Primary key of Student", "B. Foreign key referencing Section", "C. Navigation property", "D. Database connection string" }, CorrectAnswer = "B. Foreign key referencing Section", Explanation = "SectionId holds the foreign key value linking Student to the Section entity." },
                new QuestionItem { Id = 8, Question = "In the provided example, what is SectionId?", Options = new List<string>{ "A. Primary key of Student", "B. Foreign key referencing Section", "C. Navigation property", "D. Database connection string" }, CorrectAnswer = "B. Foreign key referencing Section", Explanation = "SectionId holds the foreign key value linking Student to the Section entity." },











            };

            return View(examQuestions);
        }
    }
}