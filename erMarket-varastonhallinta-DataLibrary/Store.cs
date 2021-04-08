using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erMarket_varastonhallinta_DataLibrary
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Supervisor { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public List<Product> Products { get; set; }

        public Store()
        {
            Products = new List<Product>();
        }
    }
}
