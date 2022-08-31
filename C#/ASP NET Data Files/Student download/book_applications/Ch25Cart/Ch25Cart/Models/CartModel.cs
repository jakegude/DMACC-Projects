using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ch25Cart.Models
{
    public class CartModel
    {
        public CartViewModel GetCart()
        {
            // create a new cart view model, load its product
            // view model collection, and return
            CartViewModel cart = new CartViewModel();
            cart.CartItems = GetCartItemsFromDataStore();
            return cart;
        }
        public void AddToCart(OrderViewModel order)
        {
            string id = order.SelectedProduct.ProductID;
            if (!string.IsNullOrEmpty(id))
            {
                // get complete product info from Order model
                OrderModel orderData = new OrderModel();
                orderData.LoadOrder(order, id);

                // attempt to retrieve selected product from cart
                CartViewModel cart = GetCart();
                ProductViewModel existing = (from p in cart.CartItems
                                             where p.ProductID == id
                                             select p).SingleOrDefault();

                // if selected product is in cart, increment quantity
                // otherwise, add selected product to cart
                if (existing != null)
                    existing.Quantity += order.SelectedProduct.Quantity;
                else 
                    cart.CartItems.Add(order.SelectedProduct);
            }
        }

        //Data Access method
        private List<ProductViewModel> GetCartItemsFromDataStore()
        {
            // get cart objects from session. If nothing there, 
            // add new cart object to session and return that object
            List<ProductViewModel> cartItems;
            object objCart = HttpContext.Current.Session["cart"];
            cartItems = (List<ProductViewModel>)objCart;
            if (cartItems == null) {
                cartItems = new List<ProductViewModel>();
                HttpContext.Current.Session["cart"] = cartItems;
            }
            return cartItems;
        }

    }
}