using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;


namespace MatchingSystem.UI.Controllers
{
    [Authorize(Roles = "Student")]
    public class StudentController : Controller
    {
        /*
     private readonly IStudentRepository studentRepository;
     private readonly IDictionaryRepository dictionaryRepository;
     private readonly IMatchingRepository matchingRepository;
     private SessionData data;
     private Student student;
        
     public StudentController(IStudentRepository studentRepository, IDictionaryRepository dictionaryRepository, IMatchingRepository matchingRepository)
     {
         
         this.studentRepository = studentRepository;
         this.dictionaryRepository = dictionaryRepository;
         this.matchingRepository = matchingRepository;  
 }  

              */
        public override void OnActionExecuting(ActionExecutingContext ctx)
        {
            throw new NotImplementedException(); /*
            base.OnActionExecuting(ctx);
            data ??= HttpContext.Session.Get<SessionData>("Data");
            var studentId = studentRepository.GetStudentId(data.User.UserID, data.SelectedMatching);
            student = studentRepository.GetStudent(studentId);     */
        }

        public override void OnActionExecuted(ActionExecutedContext ctx)
        {
            /*
               base.OnActionExecuted(ctx);
               data.CurrentStage = matchingRepository.GetCurrentStage(data.SelectedMatching);
               HttpContext.Session.Set<SessionData>("Data", data);      */
        }

        public IActionResult Index()
        {
            return View("~/Views/General/Index.cshtml", null); // data.User);
        }

        public IActionResult Profile()
        {              /*
            StudentViewModel model = new StudentViewModel
            {
                Student = student,
                Technology = dictionaryRepository.GetTechnologiesAll(),
                WorkDirection = dictionaryRepository.GetWorkDirectionsAll()
            };   */

            return View(); //model);
        }

        public IActionResult Preferences()
        {
            return View(); //student.StudentID);
        }
    }
}