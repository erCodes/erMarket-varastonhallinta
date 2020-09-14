using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using erMarket_varastonhallinta_Dal.Dao;
using erMarket_varastonhallinta_DataLibrary;
using Microsoft.EntityFrameworkCore;

namespace erMarket_varastonhallinta_Dal.Repositories
{
    public class ProductRepository
    {
        public static bool AddProduct(NewProductToDb newProduct)
        {
            try
            {
                using (Context db = new Context())
                {
                    DaoProduct data = new DaoProduct()
                    {
                      Name = newProduct.Name,
                      Categories = new List<DaoProductCategory>(),
                      InStock = int.Parse(newProduct.InStock),
                      QuantityChanged = newProduct.QuantityChanged
                    };

                    foreach (ProductCategory category in newProduct.Groups)
                    {
                        DaoProductCategory daoProductCategory = new DaoProductCategory
                        {
                            CategorysId = category.Id,
                            CategorysName = category.Name
                        };

                        data.Categories.Add(daoProductCategory);
                    }

                    DaoStore store = db.Stores.FirstOrDefault(x => x.Id == newProduct.Store);

                    if (store.Products == null)
                    {
                        store.Products = new List<DaoProduct>();
                    }

                    data.ProductsId = store.Products.Count + 1;

                    store.Products.Add(data);
                    db.Entry(store).State = EntityState.Modified;

                    db.SaveChanges();
                    return true;
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
    }
}
