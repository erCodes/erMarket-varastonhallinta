using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
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
            // Work in progress
            ProductToBeChanged data = JsonSerializer.Deserialize<ProductToBeChanged>(value);

            return Ok();
        }
    }
}
