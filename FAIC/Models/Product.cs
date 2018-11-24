using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace FAIC.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public String ProductName { get; set; }
        public int SupplierID { get; set; }
        public int CategoryID { get; set; }
        public int QuantityPerUnit { get; set; }
        public int UnitPrice { get; set; }
        public String UnitsInStock { get; set; }
        public String UnitsOnorder { get; set; }
        public String ReorderLevel { get; set; }
        public String Discontinued { get; set; }
        [ForeignKey("CategoryID")]
        public Category Category { get; set; }

    }
}
