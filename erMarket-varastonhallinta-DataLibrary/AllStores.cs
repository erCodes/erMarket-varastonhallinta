using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erMarket_varastonhallinta_DataLibrary
{
    public class AllStores
    {
        // This file is temporary and it will be replaced as the work progresses.
        public static List<Store> GetStores(List<ProductCategory> productCategories)
        {
            List<Store> stores = new List<Store>();

            stores.Add(new Store {
            Id = 1,
            City = "Helsinki",
            Address = "Simonkatu 14",
            Supervisor = "-",
            Phone = "000000001",
            Email = "hlki@ermarket.fi"
            });

            stores[0].Products.Add(new Product {
            Id = 0,
            Name = "Lehtisalaatti",
            InStock = 30,
            QuantityChanged = Convert.ToDateTime("16/7/2020"),
            });

            stores[0].Products[0].Groups.Add(productCategories[0]);
            stores[0].Products[0].Groups.Add(productCategories[1]);

            stores[0].Products.Add(new Product
            {
                Id = 1,
                Name = "Rasvaton maito",
                InStock = 40,
                QuantityChanged = Convert.ToDateTime("20/7/2020"),
            });

            stores[0].Products[1].Groups.Add(productCategories[0]);
            stores[0].Products[1].Groups.Add(productCategories[5]);
            stores[0].Products[1].Groups.Add(productCategories[7]);

            stores.Add(new Store
            {
                Id = 2,
                City = "Tampere",
                Address = "Rautatienkatu 10",
                Supervisor = "-",
                Phone = "000000002",
                Email = "tmpr@ermarket.fi"
            });

            stores.Add(new Store
            {
                Id = 3,
                City = "Jyväskylä",
                Address = "Kauppakatu 24",
                Supervisor = "-",
                Phone = "000000003",
                Email = "jkl@ermarket.fi"
            });

            stores.Add(new Store
            {
                Id = 4,
                City = "Oulu",
                Address = "Saaristonkatu 8",
                Supervisor = "-",
                Phone = "000000004",
                Email = "oulu@ermarket.fi"
            });

            return stores;
        }
    }
}
