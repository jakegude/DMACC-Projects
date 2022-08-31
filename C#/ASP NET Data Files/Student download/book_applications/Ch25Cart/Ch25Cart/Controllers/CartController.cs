using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
// make sure to include these using statements
using Ch25Cart.Models;

namespace Ch25Cart.Controllers
{
    public class CartController : Controller
    {
        private CartModel cartData = new CartModel();

        [HttpGet]
        public RedirectToRouteResult Index()
        {
            return RedirectToAction("List/");
        }
        [HttpGet]
        public ViewResult List()
        {
            CartViewModel cart = (CartViewModel)TempData["cart"];
            if (cart == null)
                cart = cartData.GetCart();
            return View(cart);
        }
        [HttpPost]
        public RedirectToRouteResult List(OrderViewModel order)
        {
            cartData.AddToCart(order);

            TempData["cart"] = cartData.GetCart();
            return RedirectToAction("List", "Cart");
        }
    }
}