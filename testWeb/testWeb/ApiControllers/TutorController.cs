using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace MatchingSystem.UI.ApiControllers
{
    [ApiController]
    public class TutorController : ControllerBase
    {
     

        [Route("api/[controller]/getChoice")]
        public IActionResult GetChoice(int tutorId)
        {
            throw new NotImplementedException();

        }
        
        [Route("api/[controller]/set_ready")]
        [HttpPatch]
        public async Task<IActionResult> SetReady([FromQuery] int tutorId)
        {
            throw new NotImplementedException();

        }

        [Route("api/[controller]/saveChoice")]
        [HttpPatch]
        public IActionResult SaveChoice([FromBody] List<TutorChoice_1> data, [FromQuery] int tutorId)
        {
            throw new NotImplementedException();

        }
    }
}