using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using erMarket_varastonhallinta_Dal.Dao;
using erMarket_varastonhallinta_Dal.Dao.LogDbClasses;
using erMarket_varastonhallinta_DataLibrary;

namespace erMarket_varastonhallinta_Dal.Repositories
{
    public class LogRepository
    {
        public static bool AddEntryToLog(ChangeLogData data)
        {
            try
            {
                using (Context db = new Context())
                {
                    LogData newEntry = new LogData()
                    {
                        UserAction = 0,
                        StoreId = data.StoreId,
                        ProductsId = data.ProductsId,
                        ProductsName = data.ProductsName,
                        Categories = new List<LogProductCategory>(),
                        NewCategories = null,
                        OldAmount = 0,
                        NewAmount = data.NewAmount,
                        Timestamp = data.Timestamp
                    };

                    foreach (ProductCategory pc in data.Categories)
                    {
                        LogProductCategory category = new LogProductCategory()
                        {
                            CategorysId = pc.Id,
                            CategorysName = pc.Name
                        };
                        newEntry.Categories.Add(category);
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
    }
}
