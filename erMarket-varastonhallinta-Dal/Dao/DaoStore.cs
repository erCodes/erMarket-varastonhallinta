using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace erMarket_varastonhallinta_Dal.Dao
{
    public class DaoStore
    {
        [Key]
        public int Id { get; set; }

        public int StoresId { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Supervisor { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public List<DaoProduct> Products { get; set; }
    }
}
