using Microsoft.AspNetCore.Mvc;
using Parcel.Models;

namespace Parcel.Controllers
{
  public class ParcelController : Controller
  {
    [HttpGet("/parcels")]
    public ActionResult Index()
    {
      return View(ParcelItem.GetAll());
    }

    [HttpGet("/parcels/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/parcels")]
    public ActionResult AddParcel(string weight, string height, string length, string width)
    {
      ParcelItem newParcel = new(int.Parse(weight), int.Parse(height), int.Parse(width), int.Parse(length));
      return RedirectToAction("Index");
    }

    [HttpGet("/parcels/clear")]
    public ActionResult ClearParcels()
    {
      ParcelItem.ClearAll();
      //return View("Clear");
      return RedirectToAction("Index");
    }


  }
}