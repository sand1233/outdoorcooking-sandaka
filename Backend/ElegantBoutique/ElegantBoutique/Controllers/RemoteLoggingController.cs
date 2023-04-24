using ElegantBoutique.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElegantBoutique.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RemoteLoggingController : ControllerBase
    {
        private readonly ILogger Logger;

        public RemoteLoggingController(ILogger<RemoteLoggingController> logger) : base()
        {
            Logger = logger;
        }

        [HttpPost]
        public void Post(LogMessage logMessage)
        {
            Logger.LogError("Remote message: {message}, Stack trace: {stackTrace}", logMessage.Message, logMessage.StackTrace);
        }
    }
}
