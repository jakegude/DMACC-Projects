using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// make sure to include these using directives
using System.ComponentModel.DataAnnotations;

namespace Ch18ProductMaintenance_CF.Models
{
    public class ProductMetadata
    {
        [Required]
        [ConcurrencyCheck]
        public string ProductID;

        [ConcurrencyCheck]
        public string Name { get; set; }

        [ConcurrencyCheck]
        public string ShortDescription { get; set; }

        [ConcurrencyCheck]
        public string LongDescription { get; set; }

        [ConcurrencyCheck]
        public string CategoryID { get; set; }

        [ConcurrencyCheck]
        public string ImageFile { get; set; }

        [Range(1.0, 499.99)]
        [ConcurrencyCheck]
        public decimal UnitPrice { get; set; }

        [Range(1, 50)]
        [ConcurrencyCheck]
        public int OnHand { get; set; }
    }

    public class CategoryMetadata
    {
        [Required]
        public string CategoryID;
    }
}
