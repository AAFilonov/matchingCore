using System;
using Microsoft.AspNetCore.Mvc;

namespace MatchingSystem.UI.ApiControllers
{
    [ApiController]
    public class StudentController : ControllerBase
    {

        [Route("api/[controller]/get_selected_info")]
        [HttpGet]
        public IActionResult GetSelectedParams(int studentId)
        {
            throw new NotImplementedException();

        }

        [Route("api/[controller]/edit_profile")]
        [HttpPatch]
        public IActionResult EditProfile()
        {
            throw new NotImplementedException();

        }

        [Route("api/[controller]/get_projects")]
        [HttpGet]
        public IActionResult GetProjects([FromQuery] int studentId)
        {
            throw new NotImplementedException();

        }

        [Route("api/[controller]/set_preferences")]
        [HttpPost]
        public IActionResult SetPreferences()
        {
            throw new NotImplementedException();

        }

        [Route("api/[controller]/getStudentInfo")]
        [HttpGet]
        public IActionResult GetStudentInfo([FromQuery] int? studentId)
        {
            throw new NotImplementedException();

        }

        [Route("api/[controller]/getAllocatedProject")]
        [HttpGet]
        public IActionResult GetAllocatedProject([FromQuery] int? studentId)
        {
            throw new NotImplementedException();

        }
    }
}