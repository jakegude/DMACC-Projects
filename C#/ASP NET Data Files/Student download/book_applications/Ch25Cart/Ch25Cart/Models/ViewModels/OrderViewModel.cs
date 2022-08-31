using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// make sure to include these using directives
using System.Web.Mvc;

namespace Ch25Cart.Models
{
    public class OrderViewModel
    {
        public SelectList ProductsList { get; set; }
        public ProductViewModel SelectedProduct { get; set; }

        // constructor
        public OrderViewModel() {
            this.SelectedProduct = new ProductViewModel();
        }
    }
}