using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace erMarket_varastonhallinta_Dal.Dao.LogDbClasses
{
    public class LogProductCategory
    {
        [Key]
        public int Id { get; set; }

        public int CategorysId { get; set; }
        public string CategorysName { get; set; }
    }
}
