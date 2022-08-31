using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// make sure to include these using directives
using System.ComponentModel.DataAnnotations;

namespace Ch18ProductMaintenance_CF.Models
{
    [MetadataType(typeof(ProductMetadata))]
    public partial class Product
    {
    }

    [MetadataType(typeof(CategoryMetadata))]
    public partial class Category
    {
    }
}
