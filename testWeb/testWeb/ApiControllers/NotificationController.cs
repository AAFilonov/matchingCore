using System;
using Microsoft.AspNetCore.Mvc;

namespace MatchingSystem.UI.ApiControllers
{
    [ApiController]
    public class NotificationController : ControllerBase
    {
      
        [Route("api/[controller]/get_notifications")]
        [HttpGet]
        public IActionResult GetNotificationsByExecutive(int userId, int matchingId)
        {
            throw new NotImplementedException();
        }

        [Route("api/[controller]/getNotificationsByTutor")]
        [HttpGet]
        public IActionResult GetNotificationsByTutor(int tutorId, int userId, int matchingId)
        {
            throw new NotImplementedException();
        }
    }
}