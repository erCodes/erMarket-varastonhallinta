using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using erMarket_varastonhallinta_DataLibrary;
using System.Text.Json;

namespace erMarket_varastonhallinta_Api.Controllers
{
    [Route("api/newproduct")]
    [ApiController]
    public class NewProductController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> NewProduct([FromBody]string value)
        {
            NewProductToDb data = JsonSerializer.Deserialize<NewProductToDb>(value);

            return Ok(data);
        }
    }
}
