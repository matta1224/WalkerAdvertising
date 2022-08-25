using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WalkerAdvertising.Models;

namespace WalkerAdvertising.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LeadsController : ControllerBase
    {
    
        private readonly ILogger<LeadsController> _logger;

        public LeadsController(ILogger<LeadsController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [Route("Save")]
        [Consumes("application/json")]
        [Produces("application/json")]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(BadRequestObjectResult), 400)]
        public ApiResultModel<bool> Post(Lead lead)
        {
            _logger.LogTrace(Newtonsoft.Json.JsonConvert.SerializeObject(lead));

            var success = false;
            var rsponsStatus = System.Net.HttpStatusCode.OK;
            if(string.IsNullOrWhiteSpace(lead.Name) ||
                string.IsNullOrWhiteSpace(lead.PhoneNumber) ||
                string.IsNullOrWhiteSpace(lead.ProviderId) ||
                string.IsNullOrWhiteSpace(lead.ZipCode) 
            )
            {
                rsponsStatus = System.Net.HttpStatusCode.BadRequest;
            }
            else
            {
                // TODO: Save lead into db

                if (lead.AllowCommunicateEmail)
                {
                    //TODO: send email
                }
                if (lead.AllowCommunicateText)
                {
                    //TODO: send text
                }
                success = true;
            }

            _logger.LogTrace(success.ToString());

            return new ApiResultModel<bool> {
                Result = success,
                HttpStatusCode = rsponsStatus,
                Message = ""     
            };


        }
    }
}
