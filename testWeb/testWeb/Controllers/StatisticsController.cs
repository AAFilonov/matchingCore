﻿using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace MatchingSystem.UI.Controllers
{
    [Authorize(Roles = "Executive")]
    public class StatisticsController : Controller
    {
        /*
        private readonly IMatchingRepository matchingRepository;
        private readonly IStatisticsRepository statisticsRepository;
        private SessionData data;
                                    
        public StatisticsController(IMatchingRepository matchingRepository, IStatisticsRepository statisticsRepository)
        {
            this.matchingRepository = matchingRepository;
            this.statisticsRepository = statisticsRepository;
        }
                 */
        public override void OnActionExecuting(ActionExecutingContext ctx)
        {
            throw new NotImplementedException();/*
            base.OnActionExecuting(ctx);
            if (data == null)
            {
                data = HttpContext.Session.Get<SessionData>("Data");
            }         */
        }

        public override void OnActionExecuted(ActionExecutedContext ctx)
        {
            throw new NotImplementedException();/*
            base.OnActionExecuted(ctx);
            data.CurrentStage = matchingRepository.GetCurrentStage(data.SelectedMatching);
            HttpContext.Session.Set<SessionData>("Data", data);          */
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View("~/Views/General/Index.cshtml", null); //data.User);
        }
        
        [HttpGet]
        public IActionResult Main()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Students()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Tutors()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Groups()
        {
            return View();
        }

        
    }
}