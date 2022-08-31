using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
// make sure to include these using statements
using Ch25Cart.Models;

namespace Ch25Cart.Controllers
{
    public class OrderController : Controller
    {
        [HttpGet]
        public ActionResult Index(string id)
        {
            OrderModel orderData = new OrderModel();

            // get list for drop down from temp data 
            SelectList products = (SelectList)TempData["products"];

            // if nothing in temp data, get list of products from 
            // model and load them in to an MVC SelectList object
            if (products == null)
            {
                var list = orderData.GetProductsList();
                products = new SelectList(list, "ProductId", "Name", id);
            }
            // if no URL parameter, get first product from list and reload page
            if (string.IsNullOrEmpty(id)) {
                id = products.ElementAt(0).Value;
                TempData["products"] = products;
                return RedirectToAction("Index", "Order", new { id });
            }
            else { // prepare a view model object with data needed by the page
                   // and pass it to the View method
                OrderViewModel order = new OrderViewModel();
                orderData.LoadOrder(order, id);
                order.ProductsList = products;
                return View(order);
            }
        }
        [HttpPost] // post back - get selected drop-down value and reload page
        public RedirectToRouteResult Index(FormCollection form)
        {
            string pID = form["ddlProducts"];
            return RedirectToAction("Index", "Order", new { id = pID });
        }
    }
}