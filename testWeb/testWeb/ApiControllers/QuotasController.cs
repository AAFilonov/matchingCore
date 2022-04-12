using System;

using MatchingSystem.UI.RequestModels;
using MatchingSystem.UI.ResultModels;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace MatchingSystem.UI.ApiControllers
{
    [ApiController]
    public class QuotasController : ControllerBase
    {
        [Route("api/[controller]/tutor/initialize")]
        [HttpGet]
        public IActionResult Initialize(int tutorId, int stageTypeCode)
        {
            throw new NotImplementedException();
        }

        [Route("api/[controller]/send_request")]
        [HttpPost]
        public IActionResult CreateRequest([FromBody] ChangeQuotaRequest data)
        {
            throw new NotImplementedException();
        }
        
        [Route("api/[controller]/sendRequestForLastStage")]
        [HttpPost]
        public IActionResult CreateRequestForLastStage([FromBody] ChangeQuotaRequest data)
        {
            throw new NotImplementedException();
        }

        [Route("api/[controller]/process_request")]
        [HttpPatch]
        public IActionResult AcceptRequest()
        {
            throw new NotImplementedException();
        }
    }
}