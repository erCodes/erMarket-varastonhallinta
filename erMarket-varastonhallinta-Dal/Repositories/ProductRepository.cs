using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using erMarket_varastonhallinta_Dal.Dao;
using erMarket_varastonhallinta_Dal.Dao.ProductDbClasses;
using erMarket_varastonhallinta_DataLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace erMarket_varastonhallinta_Dal.Repositories
{
    public class ProductRepository
    {
        public static (bool, int) AddProduct(NewProductToDb newProduct)
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

                    DaoStore store = db.Stores
                        .Where(x => x.Id == newProduct.Store)
                        .Include(x => x.Products)
                        .ThenInclude(x => x.Categories)
                        .FirstOrDefault();


                    if (store.Products == null)
                    {
                        store.Products = new List<DaoProduct>();
                    }

                    if (store.Products.Any())
                    {
                        data.ProductsId = store.Products.Max(x => x.ProductsId) + 1;
                    }
                    
                    else
                    {
                        data.ProductsId = 1;
                    }

                    store.Products.Add(data);
                    db.Entry(store).State = EntityState.Modified;

                    db.SaveChanges();
                    return (true, data.ProductsId);
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
                return (false, 0);
            }
        }

        public static bool ChangeQuantity(ProductToBeChanged data)
        {
            try
            {
                using (Context db = new Context())
                {
                    DaoStore store = db.Stores
                        .Where(x => x.StoresId == data.StoresId && x.Products.Any(y => y.ProductsId == data.ProductsId))
                        .Include(x => x.Products)
                        .FirstOrDefault();

                    if (store != null)
                    {
                        DaoProduct product = store.Products
                            .Where(x => x.ProductsId == data.ProductsId)
                            .First();

                        product.InStock = data.NewQuantity;
                        product.QuantityChanged = data.QuantityChanged;
                        db.Entry(product).State = EntityState.Modified;

                        db.SaveChanges();
                        return true;
                    }

                    else
                    {
                        return false;
                    }
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public static bool RemoveProduct(int storesId, int productsId)
        {
            try
            {
                using (Context db = new Context())
                {
                    DaoStore store = db.Stores
                        .Where(x => x.StoresId == storesId)
                        .Include(x => x.Products)
                        .ThenInclude(x => x.Categories)
                        .FirstOrDefault();

                    if (store != null)
                    {
                        DaoProduct product = store.Products
                            .Where(x => x.ProductsId == productsId)
                            .First();

                        foreach (var item in product.Categories)
                        {
                            db.Entry(item).State = EntityState.Deleted;
                        }

                        db.Entry(product).State = EntityState.Deleted;
                        db.SaveChanges();
                        return true;
                    }

                    else
                    {
                        return false;
                    }
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public static List<Store> GetStoreNames()
        {
            try
            {
                using (Context db = new Context())
                {
                    List<Store> Stores = db.Stores
                        .Select(x => new Store
                        {
                            Id = x.StoresId,
                            City = x.City
                        })
                        .ToList();

                    return Stores;
                }
            }

            catch (ArgumentNullException)
            {
                return null;
            }
        }

        public static List<ProductCategory> GetProductCategories()
        {
            try
            {
                using (Context db = new Context())
                {
                    List<ProductCategory> categories = db.ProductCategories
                        .Select(x => new ProductCategory
                        {
                            Id = x.CategorysId,
                            Name = x.CategorysName
                        })
                        .ToList();

                    return categories;
                }
            }

            catch
            {
                return null;
            }
        }

        public static Store GetSelectedStoresData(int id)
        {
            try
            {
                DaoStore selected = new DaoStore();
                Store returned = new Store();
                returned.Products = new List<Product>();

                using (Context db = new Context())
                {
                    DaoStore data = db.Stores
                        .Where(x => x.StoresId == id)
                        .Include(x => x.Products)
                        .ThenInclude(x => x.Categories)
                        .FirstOrDefault();

                    returned.Id = data.StoresId;
                    returned.City = data.City;
                    returned.Address = data.Address;
                    returned.Email = data.Email;
                    returned.Phone = data.Phone;
                    returned.Supervisor = data.Supervisor;
                    
                    foreach (DaoProduct dao in data.Products)
                    {
                        Product product = new Product
                        {
                            Id = dao.ProductsId,
                            Name = dao.Name,
                            InStock = dao.InStock,
                            QuantityChanged = dao.QuantityChanged
                        };

                        foreach (DaoProductCategory daoCategory in dao.Categories)
                        {
                            ProductCategory category = new ProductCategory
                            {
                                Id = daoCategory.CategorysId,
                                Name = daoCategory.CategorysName
                            };

                            product.Groups.Add(category);
                        }

                        returned.Products.Add(product);
                    }

                    return returned;
                }
            }

            catch
            {
                return null;
            }
        }
    }
}
