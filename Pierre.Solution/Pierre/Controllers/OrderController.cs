using Microsoft.AspNetCore.Mvc;
using Pierre.Models;
using System.Collections.Generic;

namespace Pierre.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("/orders/{orderId}/items/new")] // returns list of all Orders
    public ActionResult New(int orderId)
    {
      Order order = Order.Find(orderId);
      return View(order);
    }

   
    [HttpGet("/orders/{orderId}/vendors/{vendorId}")] // redirects to form 
    public ActionResult Show(int vendorId, int orderId)
    {
      Order order = Order.Find(orderId);
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", order);
      model.Add("vendor", vendor);
      return View(model);
    }
  }
}  