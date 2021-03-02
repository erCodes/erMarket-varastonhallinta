using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erMarket_varastonhallinta_DataLibrary
{
    public class ChangeLogData
    {
        // 0 = Added   1 = Modified   2 = Deleted  3 = Categories changed (upcoming feature)
        public int UserAction { get; set; }
        public int StoreId { get; set; }
        public int ProductsId { get; set; }
        public string ProductsName { get; set; }
        public List<ProductCategory> Categories { get; set; }
        public List<ProductCategory> NewCategories { get; set; }
        public int OldAmount { get; set; }
        public int NewAmount { get; set; }
        public DateTime Timestamp { get; set; }

        public ChangeLogData()
        {
            Categories = new List<ProductCategory>();
            NewCategories = new List<ProductCategory>();
        }
    }
}
