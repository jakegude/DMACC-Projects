using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ch25Cart.Models
{
    public class CartViewModel
    {
        public List<ProductViewModel> CartItems { get; set; }
    }
}