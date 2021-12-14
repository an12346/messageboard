using Microsoft.AspNetCore.Mvc;
using Parcel.Models;
using System.Collections.Generic; 

namespace Parcel.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}