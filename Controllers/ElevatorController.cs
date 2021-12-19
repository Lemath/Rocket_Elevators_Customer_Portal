using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using Rocket_Elevators_Customer_Portal.Models;

namespace Rocket_Elevators_Customer_Portal.Controllers
{
  public class ElevatorController : Controller
  {
    [Authorize]
    public async Task<IActionResult> Index()
    {
      var client = new HttpClient();
      client.BaseAddress = new Uri("https://localhost:5001/");
			var get_elevators = await client.GetAsync($"https://rocketelevator-restapi.herokuapp.com/api/Elevators/GetByCustomer/{HttpContext.User.Identity.Name}");
			var elevators_list = JArray.Parse(await get_elevators.Content.ReadAsStringAsync());
			var elevators = new List<Elevator>();
			foreach (var elevator in elevators_list)
			{
				var elevator_to_object = elevator.ToObject<Elevator>();
				elevators.Add(elevator_to_object);
			}
			ViewBag.Elevators = elevators;
      return View();
    }

    [HttpGet]
		public async Task<List<long>> ElevatorOfColumn(long id)
		{
			Console.WriteLine(id);
			var client = new HttpClient();
			client.BaseAddress = new Uri("https://localhost:5001/");
			var get_elevators = await client.GetAsync($"https://rocketelevator-restapi.herokuapp.com/api/Elevators/GetByColumn/{id}");
			var elevator_list = JArray.Parse(await get_elevators.Content.ReadAsStringAsync());
			var elevators = new List<long>();
			Console.WriteLine("parsed list");
			Console.WriteLine(elevator_list);
			foreach (var elevator in elevator_list)
			{
				var elevator_to_object = elevator.ToObject<Elevator>();
				Console.WriteLine("to object");
				Console.WriteLine(elevator_to_object);
				elevators.Add(elevator_to_object.Id);
			}
			
			return elevators;
		}
  }
}