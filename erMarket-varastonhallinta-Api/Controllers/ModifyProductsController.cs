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
                    ChangeLogData logData = new ChangeLogData()
                    {
                        UserAction = 1,
                        StoreId = data.StoresId,
                        ProductsId = data.ProductsId,
                        ProductsName = data.ProductsName,
                        Categories = data.Categories,
                        NewCategories = null,
                        OldAmount = data.OldAmount,
                        NewAmount = data.NewQuantity,
                        Timestamp = data.QuantityChanged
                    };

                    if (LogRepository.AddNewEntry(logData))
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
                    return StatusCode(500);
                }
            }

            else
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        [Route("api/removeproduct")]
        public async Task<IActionResult> RemoveProduct(int id, int ide)
        {
            int storesId = id;
            int productsId = ide;

            if (storesId >= 0 && productsId >= 0)
            {
                (bool success, Product productToLog) = (ProductRepository.RemoveProduct(storesId, productsId));

                if (success)
                {
                    ChangeLogData logData = new ChangeLogData()
                    {
                        UserAction = 2,
                        StoreId = storesId,
                        ProductsId = productToLog.Id,
                        ProductsName = productToLog.Name,
                        Categories = productToLog.Groups,
                        NewCategories = null,
                        OldAmount = productToLog.InStock,
                        NewAmount = 0,
                        Timestamp = DateTime.Now
                    };

                    if (LogRepository.AddNewEntry(logData))
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
