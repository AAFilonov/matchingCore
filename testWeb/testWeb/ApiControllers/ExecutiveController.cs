using Microsoft.AspNetCore.Mvc;
using System;

using MatchingSystem.UI.RequestModels;


namespace MatchingSystem.UI.ApiControllers
{
    [ApiController]
    public class ExecutiveController : ControllerBase
    {
        /*
        private readonly ITutorRepository tutorRepository;
        private readonly IExecutiveRepository executiveRepository;
        private readonly IMatchingRepository matchingRepository;
        private readonly IProjectRepository projectRepository;

        public ExecutiveController(
            ITutorRepository tutorRepository, 
            IExecutiveRepository executiveRepository, 
            IMatchingRepository matchingRepository, 
            IProjectRepository projectRepository
            )
        {
            this.tutorRepository = tutorRepository;
            this.executiveRepository = executiveRepository;
            this.matchingRepository = matchingRepository;
            this.projectRepository = projectRepository;
        }
               */
        [Route("api/[controller]/setNextStage")]
        [HttpPatch]
        public IActionResult SetNextStage([FromQuery] int? matchingId, [FromQuery] int? userId)
        {
            throw new NotImplementedException();
        }

        [Route("api/[controller]/setEndDate")]
        [HttpPatch]
        public IActionResult SetEndDate([FromForm] string endDate, [FromForm] int matchingId)
        {
            throw new NotImplementedException();
        }

   
        
        
        
        [Route("api/[controller]/getAllocation")]
        [HttpGet]
        public IActionResult GetAllocationByExecutive([FromQuery] int? userId, [FromQuery] int? matchingId)
        {
            throw new NotImplementedException();
        }

        [Route("api/[controller]/setAllocation")]
        [HttpPatch]
        public IActionResult SetAllocationByExecutive([FromBody] AdjustmentRequest request)
        {
            throw new NotImplementedException();
        }
    }
}