using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using erMarket_varastonhallinta_DataLibrary;
using System.Text.Json;
using erMarket_varastonhallinta_Dal.Repositories;
using System.Net.WebSockets;

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

            if (data.Name.Length > 50)
            {
                return BadRequest(1);
            }

            else if (!double.TryParse(data.InStock, out double num))
            {
                return BadRequest(2);
            }

            // Data is valid
            else
            {
                if (ProductRepository.AddProduct(data))
                {
                    return Ok();
                }

                else
                {
                    return StatusCode(500);
                }
            }
        }
    }
}
