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
                (bool success, int productsId) = (ProductRepository.AddProduct(data));

                if (success)
                {
                    ChangeLogData logData = new ChangeLogData
                    {
                        UserAction = 0,
                        StoreId = data.Store,
                        ProductsId = productsId,
                        ProductsName = data.Name,
                        Categories = data.Groups,
                        NewCategories = null,
                        OldAmount = 0,
                        NewAmount = int.Parse(data.InStock),
                        Timestamp = data.QuantityChanged
                    };

                    if (LogRepository.AddEntryToLog(logData))
                    {
                        return Ok();
                    }

                    else
                    {
                        return StatusCode(500);
                    }
                }

                // 500 = server error
                else
                {
                    return StatusCode(500);
                }
            }
        }
    }
}
