using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

using MatchingSystem.UI.RequestModels;


namespace MatchingSystem.UI.ApiControllers
{
    [ApiController]
    public class ProjectsController : ControllerBase
    {        /*
        private readonly IDictionaryRepository dictionaryRepository;
        private readonly ITutorRepository tutorRepository;
        private readonly IMatchingRepository matchingRepository;
        private readonly IProjectRepository projectRepository;

        public ProjectsController(
            IDictionaryRepository dictionaryRepository, 
            ITutorRepository tutorRepository, 
            IMatchingRepository matchingRepository,
            IProjectRepository projectRepository
            )
        {
            this.dictionaryRepository = dictionaryRepository;
            this.tutorRepository = tutorRepository;
            this.matchingRepository = matchingRepository;
            this.projectRepository = projectRepository;
        }
                 */
        [Route("api/[controller]/tutor/add_project")]
        [HttpPost]
        public IActionResult AddTutorProject([FromForm] ProjectRequest project)
        {
            throw new NotImplementedException();
        }

        [Route("api/[controller]/tutor/edit_project")]
        [HttpPut]
        public IActionResult EditProject([FromForm] ProjectRequest project)
        {
            throw new NotImplementedException();
           
        }

        [Route("api/[controller]/delete")]
        [HttpDelete]
        public IActionResult DeleteProject([FromQuery] int projectId)
        {
            throw new NotImplementedException();
        }

        [Route("api/[controller]/get_projects_data")]
        [HttpGet]
        public IActionResult GetProjectsData([FromQuery] int tutorId)
        {
            throw new NotImplementedException();
        }

        [Route("api/[controller]/editQuotaPerProject")]
        [HttpPatch]
        public IActionResult EditQuota()
        {
            throw new NotImplementedException();
          
            
        }

        [Route("api/[controller]/closeProject")]
        [HttpPatch]
        public IActionResult CloseProject(int tutorId, int projectId)
        {
            throw new NotImplementedException();
        }

        [Route("api/[controller]/getProjectsByTutor")]
        [HttpGet]
        public IActionResult GetProjectsByTutor([FromQuery] int tutorId)
        {
            throw new NotImplementedException();
        }
    }
}