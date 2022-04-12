using Microsoft.AspNetCore.Mvc;
using System;


namespace MatchingSystem.UI.ApiControllers
{
    [ApiController]
    public class StatisticsController : ControllerBase
    {
      
        [Route("api/[controller]/getStatisticsMain")]
        [HttpGet]
        public IActionResult GetStatisticsMain([FromQuery] int? matchingId, [FromQuery] int? currentStage)
        {
            throw new NotImplementedException();
            
        }
        
        [Route("api/[controller]/getStatisticsGroups")]
        [HttpGet]
        public IActionResult GetStatisticsGroups([FromQuery] int? matchingId)
        {
            throw new NotImplementedException();
        }

        [Route("api/[controller]/getStatisticsTutors")]
        [HttpGet]
        public IActionResult GetStatisticsTutors([FromQuery] int? matchingId, [FromQuery] int? currentStage)
        {
            throw new NotImplementedException();

        }

        [Route("api/[controller]/getStatisticsStudents")]
        [HttpGet]
        public IActionResult GetStatisticsStudents([FromQuery] int? matchingId, [FromQuery] int? currentStage)
        {
            throw new NotImplementedException();

        }


        [Route("api/[controller]/getStatisticsTutorProjectAllocated")]
        [HttpGet]
        public IActionResult GetStatisticsTutorsProjectAllocated([FromQuery] int? matchingId, [FromQuery] int? tutorId)
        {
            throw new NotImplementedException();

        }
        
        
        [Route("api/[controller]/getStatisticsStudentsProjects")]
        [HttpGet]
        public IActionResult GetStatisticsStudentsProjects([FromQuery] int? matchingId, [FromQuery] int? studentId)
        {
            throw new NotImplementedException();

        }

 
        [Route("api/[controller]/getStatisticsTutorProjects")]
        [HttpGet]
        public IActionResult GetStatisticsTutorsProjects([FromQuery] int? matchingId, [FromQuery] int? tutorId)
        {
            throw new NotImplementedException();


        }


    }
}