using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erMarket_varastonhallinta_DataLibrary
{
    public class NewProductToDb
    {
        public int Store { get; set; }
        public string Name { get; set; }
        public string InStock { get; set; }
        public List<ProductCategory> Groups { get; set; }
        public DateTime QuantityChanged { get; set; }

        public NewProductToDb()
        {
            Groups = new List<ProductCategory>();
        }
    }
}
