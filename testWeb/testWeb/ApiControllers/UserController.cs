
using System;
using Microsoft.AspNetCore.Mvc;

namespace MatchingSystem.UI.ApiControllers
{
    [ApiController]
    public class UserController : ControllerBase
    {
    

        [Route("api/[controller]/getMatchings")]
        [HttpGet]
        public IActionResult GetMatchingsForUser([FromQuery] int userId)
        {
            throw new NotImplementedException();

        }

        [Route("api/[controller]/getRoles")]
        [HttpGet]
        public IActionResult GetRolesForUser([FromQuery] int matchingId, [FromQuery] int userId)
        {
            throw new NotImplementedException();

        }
    }
}