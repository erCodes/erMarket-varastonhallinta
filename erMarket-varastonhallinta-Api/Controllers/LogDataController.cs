using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using erMarket_varastonhallinta_DataLibrary;
using erMarket_varastonhallinta_Dal.Repositories;

namespace erMarket_varastonhallinta_Api.Controllers
{
    [ApiController]
    public class LogDataController : Controller
    {
        [HttpGet]
        [Route("api/getlogdata")]
        public async Task<IActionResult> GetLogData()
        {
            List<ChangeLogData> logData = LogRepository.GetLogData();

            if (logData != null)
            {
                return Ok(logData);
            }

            else
            {
                return StatusCode(500);
            }
        }
    }
}
