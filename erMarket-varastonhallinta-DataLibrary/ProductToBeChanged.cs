using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erMarket_varastonhallinta_DataLibrary
{
    public class ProductToBeChanged
    {
        public int StoresId { get; set; }
        public int ProductsId { get; set; }
        public string ProductsName { get; set; }
        public int NewQuantity { get; set; }
        public DateTime QuantityChanged { get; set; }
    }
}
