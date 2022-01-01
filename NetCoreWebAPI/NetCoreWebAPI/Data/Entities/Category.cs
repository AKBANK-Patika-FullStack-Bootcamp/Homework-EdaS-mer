using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreWebAPI.Data.Entities
{
    public class Category
    {
        [Key] // bu stun primary key yapıyor
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}
