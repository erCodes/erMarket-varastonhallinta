using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace erMarket_varastonhallinta_Dal.Dao.LogDbClasses
{
    public class LogData
    {
        [Key]
        public int Id { get; set; }

        public int UserAction { get; set; }
        public int StoreId { get; set; }
        public int ProductsId { get; set; }
        public string ProductsName { get; set; }
        public List<LogProductCategory> Categories { get; set; }
        public List<LogProductCategory> NewCategories { get; set; }
        public int OldAmount { get; set; }
        public int NewAmount { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
