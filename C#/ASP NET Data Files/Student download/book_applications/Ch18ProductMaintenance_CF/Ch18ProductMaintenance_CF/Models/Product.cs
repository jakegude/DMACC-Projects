namespace Ch18ProductMaintenance_CF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        [StringLength(10)]
        public string ProductID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(200)]
        public string ShortDescription { get; set; }

        [Required]
        [StringLength(2000)]
        public string LongDescription { get; set; }

        [Required]
        [StringLength(10)]
        public string CategoryID { get; set; }

        [StringLength(30)]
        public string ImageFile { get; set; }

        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }

        public int OnHand { get; set; }

        public virtual Category Category { get; set; }
    }
}
