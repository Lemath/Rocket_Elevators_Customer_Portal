using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Rocket_Elevators_Customer_Portal.Models;

namespace Rocket_Elevators_Customer_Portal.Controllers
{
  public class BatteryController : Controller
  {
    [Authorize]
    public IActionResult Index()
        {
            return View();
        }
  }
}