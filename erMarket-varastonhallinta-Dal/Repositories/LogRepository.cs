using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using erMarket_varastonhallinta_Dal.Dao;
using erMarket_varastonhallinta_Dal.Dao.LogDbClasses;
using erMarket_varastonhallinta_DataLibrary;
using Microsoft.EntityFrameworkCore;

namespace erMarket_varastonhallinta_Dal.Repositories
{
    public class LogRepository
    {
        public static bool AddNewEntry(ChangeLogData data)
        {
            try
            {
                using (Context db = new Context())
                {
                    LogData newEntry = new LogData()
                    {
                        UserAction = data.UserAction,
                        StoreId = data.StoreId,
                        ProductsId = data.ProductsId,
                        ProductsName = data.ProductsName,
                        OldAmount = data.OldAmount,
                        NewAmount = data.NewAmount,
                        Timestamp = data.Timestamp
                    };

                    if (data.Categories != null)
                    {
                        newEntry.Categories = new List<LogProductCategory>();

                        foreach (ProductCategory pc in data.Categories)
                        {
                            LogProductCategory category = new LogProductCategory()
                            {
                                CategorysId = pc.Id,
                                CategorysName = pc.Name
                            };
                            newEntry.Categories.Add(category);
                        }
                    }
                    
                    if (data.NewCategories != null)
                    {
                        newEntry.NewCategories = new List<LogProductCategory>();

                        foreach (ProductCategory pc in data.NewCategories)
                        {
                            LogProductCategory category = new LogProductCategory()
                            {
                                CategorysId = pc.Id,
                                CategorysName = pc.Name
                            };
                            newEntry.NewCategories.Add(category);
                        }
                    }

                    db.ChangeLog.Add(newEntry);
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

        public static List<ChangeLogData> GetLogData()
        {
            try
            {
                using (Context db = new Context())
                {
                    List<LogData> log = db.ChangeLog
                        .Include(x => x.Categories)
                        .Include(x => x.NewCategories)
                        .Select(x => new LogData
                        {
                            Id = x.Id,
                            UserAction = x.UserAction,
                            StoreId = x.StoreId,
                            ProductsId = x.ProductsId,
                            ProductsName = x.ProductsName,
                            Categories = x.Categories,
                            NewCategories = x.NewCategories,
                            OldAmount = x.OldAmount,
                            NewAmount = x.NewAmount,
                            Timestamp = x.Timestamp
                        })
                        .ToList();

                    List<ChangeLogData> data = new List<ChangeLogData>();

                    foreach (LogData ld in log)
                    {
                        ChangeLogData entry = new ChangeLogData()
                        {
                            UserAction = ld.UserAction,
                            StoreId = ld.StoreId,
                            ProductsId = ld.ProductsId,
                            ProductsName = ld.ProductsName,
                            OldAmount = ld.OldAmount,
                            NewAmount = ld.NewAmount,
                            Timestamp = ld.Timestamp
                        };

                        foreach (LogProductCategory c in ld.Categories)
                        {
                            ProductCategory category = new ProductCategory()
                            {
                                Id = c.CategorysId,
                                Name = c.CategorysName
                            };

                            entry.Categories.Add(category);
                        }

                        foreach (LogProductCategory nc in ld.NewCategories)
                        {
                            ProductCategory newCategory = new ProductCategory()
                            {
                                Id = nc.CategorysId,
                                Name = nc.CategorysName
                            };

                            entry.NewCategories.Add(newCategory);
                        }

                        data.Add(entry);
                    }

                    return data;
                    //foreach (LogData row in db.ChangeLog)
                    //{
                    //    ChangeLogData newItem = new ChangeLogData()
                    //    {
                    //        UserAction = row.UserAction,
                    //        StoreId = row.StoreId,
                    //        ProductsId = row.ProductsId,
                    //        ProductsName = row.ProductsName,
                    //        OldAmount = row.OldAmount,
                    //        NewAmount = row.NewAmount,
                    //        Timestamp = row.Timestamp
                    //    };

                    //    if (row.Categories != null)
                    //    {
                    //        newItem.Categories = new List<ProductCategory>();

                    //        foreach (LogProductCategory pc in row.Categories)
                    //        {
                    //            ProductCategory category = new ProductCategory()
                    //            {
                    //                Id = pc.CategorysId,
                    //                Name = pc.CategorysName
                    //            };

                    //            newItem.Categories.Add(category);
                    //        }
                    //    }

                    //    if (row.NewCategories != null)
                    //    {
                    //        newItem.NewCategories = new List<ProductCategory>();

                    //        foreach (LogProductCategory pc in row.NewCategories)
                    //        {
                    //            ProductCategory category = new ProductCategory()
                    //            {
                    //                Id = pc.CategorysId,
                    //                Name = pc.CategorysName
                    //            };

                    //            newItem.NewCategories.Add(category);
                    //        }
                    //    }

                    //    data.Add(newItem);
                    //}
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
    }
}
