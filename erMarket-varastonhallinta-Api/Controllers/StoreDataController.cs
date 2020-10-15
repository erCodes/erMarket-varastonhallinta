using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using erMarket_varastonhallinta_DataLibrary;
using erMarket_varastonhallinta_Dal.Repositories;

namespace erMarket_varastonhallinta_Api.Controllers
{
    [ApiController]
    public class StoreDataController : Controller
    {
        [HttpGet]
        [Route("api/getstoresdata")]
        public async Task<IActionResult> GetStoresData([FromQuery(Name = "storeid")]int id)
        {
            int test = id;

            return Ok(test);
        }

        [HttpGet]
        [Route("api/getstorenames")]
        public async Task<IActionResult> GetStoresNames()
        {
            List<Store> Stores = ProductRepository.GetStoreNames();

            if (Stores != null)
            {
                return Ok(Stores);
            }

            else
            {
                return NoContent();
            }
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetProductCategories()
        {
            List<ProductCategory> categories = new List<ProductCategory>();

            return Ok(categories);
        }
    }
}
