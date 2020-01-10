using Microsoft.AspNetCore.Mvc;
using Pierre.Models;
using System.Collections.Generic;

namespace Pierre.Controllers
{
  public class VendorController : Controller
  {
    [HttpGet("/vendors")] // returns list of all vendors
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }
    
    [HttpGet("/vendors/new")] // redirects to form 
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")] // redirects to form 
    public ActionResult Create(string description)
    {
      Vendor myVendor = new Vendor(description);
      return RedirectToAction("Index");
    }
    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Vendor foundVendor = Vendor.Find(id);
      return View(foundVendor);
    }
  }
}  