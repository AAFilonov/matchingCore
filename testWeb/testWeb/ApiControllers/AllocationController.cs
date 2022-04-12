using System;
using Microsoft.AspNetCore.Mvc;


namespace MatchingSystem.UI.ApiControllers
{
    [ApiController]
    public class AllocationController : ControllerBase
    {
        /*
        private readonly IMatchingRepository matchingRepository;

        public AllocationController(IMatchingRepository matchingRepository)
        {
            this.matchingRepository = matchingRepository;
        }          */

        [Route("api/[controller]/getFinalAllocations")]
        [HttpGet]
        public IActionResult GetAllocations()
        {
            throw new NotImplementedException();
        }   
    }
}