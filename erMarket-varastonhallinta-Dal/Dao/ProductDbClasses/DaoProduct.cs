using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace erMarket_varastonhallinta_Dal.Dao.ProductDbClasses
{
    public class DaoProduct
    {
        [Key]
        public int Id { get; set; }

        public int ProductsId { get; set; }
        public string Name { get; set; }
        public List<DaoProductCategory> Categories { get; set; }
        public int InStock { get; set; }
        public DateTime QuantityChanged { get; set; }
    }
}
