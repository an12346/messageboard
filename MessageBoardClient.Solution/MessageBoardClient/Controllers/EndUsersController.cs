using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MessageBoardClient.Models;

namespace MessageBoardClient.Controllers
{
  public class EndUsersController : Controller
  {
    public IActionResult Index()
  {
    var allEndUsers = EndUser.GetEndUsers();
    return View(allEndUsers);
  }

  // [HttpPost]
  // public IActionResult Index(EndUser endUser)
  // {
  //   EndUser.Post(endUser);
  //   return RedirectToAction("Index");
  // }
}
}