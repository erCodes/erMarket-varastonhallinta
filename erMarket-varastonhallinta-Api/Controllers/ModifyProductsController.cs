using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using erMarket_varastonhallinta_Dal.Repositories;
using erMarket_varastonhallinta_DataLibrary;
using Microsoft.AspNetCore.Mvc;

namespace erMarket_varastonhallinta_Api.Controllers
{
    [ApiController]
    public class ModifyProductsController : Controller
    {
        [HttpPut]
        [Route("api/changeproductquantity")]
        public async Task<IActionResult> ChangeProductQuantity([FromBody]string value)
        {
            ProductToBeChanged data = JsonSerializer.Deserialize<ProductToBeChanged>(value);

            if (data.NewQuantity >= 0)
            {
                if (ProductRepository.ChangeQuantity(data))
                {
                    return Ok();
                }

                else
                {
                    return StatusCode(500);
                }
            }

            else
            {
                return BadRequest();
            }
        }
    }
}
