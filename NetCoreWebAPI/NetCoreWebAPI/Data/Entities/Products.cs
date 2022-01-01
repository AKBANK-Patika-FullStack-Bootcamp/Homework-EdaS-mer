using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreWebAPI.Data.Entities
{
    public class Products
    {

        [Key]

         public int ProductID { get; set; }
        public string ProductName { get; set; }

        //public int SupplierID { get; set; }

       // public int CategoryID { get; set; }

       // public string QuantityPerUnit { get; set; }

       

        public short UnitsInStock { get; set; }

      //  public int UnitsOnOrder { get; set; }
    }
}
