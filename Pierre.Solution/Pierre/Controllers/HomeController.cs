using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;  
using Pierre.Models;

namespace Pierre.Controllers
{
  public class HomeController : Controller
  {
   [Route("/")]
   public ActionResult Index()
   {
     return View();
   }
  }
}