using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// make sure to include these using directives
using Ch25Cart.Models.Data;

namespace Ch25Cart.Models
{
    public class OrderModel
    {
        private List<ProductViewModel> products;

        public List<ProductViewModel> GetProductsList()
        {
            if (this.products == null)
                this.products = GetAllProducts();
            return this.products;
        }

        public void LoadOrder(OrderViewModel order, string id)
        {
            if (this.products == null) {
                // get product from database and load it in a ProductViewModel object
                Product product = GetProductFromDataStoreById(id);
                LoadViewModel(product, order.SelectedProduct);
            }
            else
                // get product from the ProductViewModel collection
                order.SelectedProduct = (from p in this.products
                                         where p.ProductID == id
                                         select p).SingleOrDefault();
        }

        // private helper methods
        private List<ProductViewModel> GetAllProducts()
        {
            // get the products from the database, and then convert them
            // to ProductViewModel objects
            List<ProductViewModel> productmodels = new List<ProductViewModel>();
            List<Product> products = GetAllProductsFromDataStore();
            foreach (Product p in products)
            {
                productmodels.Add(LoadViewModel(p));
            }
            return productmodels;
        }
 
        private ProductViewModel LoadViewModel(
            Product product, ProductViewModel model = null)
        {
            // load the values from an Entity Framework Product object 
            // in to a ProductViewModel object
            if (model == null)  model = new ProductViewModel();
            model.ProductID = product.ProductID;
            model.Name = product.Name;
            model.ShortDescription = product.ShortDescription;
            model.LongDescription = product.LongDescription;
            model.UnitPrice = product.UnitPrice;
            model.ImageFile = product.ImageFile;
            if (model.Quantity == 0) model.Quantity = 1; // set default quantity
            return model;
        }

        // private data access methods 
        private Product GetProductFromDataStoreById(string id)
        {
            using (HalloweenEntities data = new HalloweenEntities()) {
                return (from p in data.Products
                        where p.ProductID == id
                        select p).SingleOrDefault();
            }
        }
        private List<Product> GetAllProductsFromDataStore()
        {
            using (HalloweenEntities data = new HalloweenEntities()) {
                return (from p in data.Products
                        orderby p.Name
                        select p).ToList();
            }
        }
    }
}