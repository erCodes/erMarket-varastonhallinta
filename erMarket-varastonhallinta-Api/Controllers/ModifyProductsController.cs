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
                        Categories = data.,
                        NewCategories = null,
                        OldAmount = 0,
                        NewAmount = int.Parse(data.InStock),
                        Timestamp = data.QuantityChanged
                    };

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

        [HttpDelete("Delete")]
        [Route("api/removeproduct")]
        public async Task<IActionResult> RemoveProduct(int id, int ide)
        {
            int storesId = id;
            int productsId = ide;

            if (storesId >= 0 && productsId >= 0)
            {
                if (ProductRepository.RemoveProduct(storesId, productsId))
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
