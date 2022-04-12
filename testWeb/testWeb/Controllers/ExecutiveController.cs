using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;


namespace MatchingSystem.UI.Controllers
{
    [Authorize(Roles = "Executive")]
    public class ExecutiveController : Controller
    {
        /*
        private readonly IMatchingRepository matchingRepository;
        private readonly IExecutiveRepository executiveRepository;
        private SessionData data;
               
        public ExecutiveController(IMatchingRepository matchingRepository, IExecutiveRepository executiveRepository)
        {
            this.matchingRepository = matchingRepository;
            this.executiveRepository = executiveRepository;
        }
              */
        public override void OnActionExecuting(ActionExecutingContext ctx)
        {
            throw new NotImplementedException();
            /*
            base.OnActionExecuting(ctx);
            if (data == null)
            {
                data = HttpContext.Session.Get<SessionData>("Data");
            }    */
        }

        public override void OnActionExecuted(ActionExecutedContext ctx)
        {
            /*
            base.OnActionExecuted(ctx);
            data.CurrentStage = matchingRepository.GetCurrentStage(data.SelectedMatching);
            HttpContext.Session.Set<SessionData>("Data", data);        */
        }

        [HttpGet]
        public IActionResult Index()
        {
            throw new NotImplementedException();
           // return View("~/Views/General/Index.cshtml", data.User);
        }

        [HttpGet]
        public IActionResult Quotas()
        {
            throw new NotImplementedException();/*
            ExecutiveQuotaViewModel model = new ExecutiveQuotaViewModel();

            model.Requests = executiveRepository.GetQuotaRequestsByExecutive(data.User.UserID, data.SelectedMatching);
            model.History = executiveRepository.GetQuotaRequestHistoryByExecutive(data.User.UserID, data.SelectedMatching);

            return View(model);       */
        }

        [HttpGet]
        public IActionResult Admin()
        {
           
          //  data.CurrentStage = matchingRepository.GetCurrentStage(data.SelectedMatching);
            return View();   
        }
        
        [HttpGet]
        public ViewResult Adjustment()
        {
            return View();
        }
    }
}