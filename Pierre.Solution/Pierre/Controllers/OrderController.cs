using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Pierre.Models;

namespace Pierre.Controllers
{
    public class OrderController : Controller
    {
        [HttpGet("orders")]
        public ActionResult Index()
        {
            List<Order> allOrders = Order.GetAll();
            return View(allOrders);
        }
        
        [HttpGet("/orders/new")]
        public ActionResult New()
        { 
         return View();
        }

        [HttpPost("/orders")]
        public ActionResult Create(string orderName)
        {
            Order newOrder = new Order(orderName);
            return RedirectToAction("Index");
        }

        [HttpGet("/orders/{id}")]
        public ActionResult Show(int id)
        {
        Dictionary<string, object> model = new Dictionary<string, object>();

        Order selectedOrder = Order.Find(id);
        List<Vendor> vendorList = selectedCategory.;

        model.Add("vendor", );
        model.Add("orders", );
        return View(model);
        }
    }
}

      Order selectedOrder = Order.Find(id);
      List<Vendor> listVendors = selectedOrder.Items;
      model.Add("category", selectedCategory);