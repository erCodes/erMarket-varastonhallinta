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
            Store data = ProductRepository.GetSelectedStoresData(id);

            if (data != null)
            {
                return Ok(data);
            }

            else
            {
                return NoContent();
            }
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
        [Route("api/getallcategories")]
        public async Task<IActionResult> GetProductCategories()
        {
            List<ProductCategory> categories = ProductRepository.GetProductCategories();

            if (categories.Any())
            {
                return Ok(categories);
            }

            else
            {
                return NoContent();
            }
        }
    }
}
