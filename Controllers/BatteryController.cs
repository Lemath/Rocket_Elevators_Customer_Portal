using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Rocket_Elevators_Customer_Portal.Models;
using System.Security.Claims;
using System.Net.Http;
using System.Net.Http.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Rocket_Elevators_Customer_Portal.Controllers
{
	public class BatteryController : Controller
	{
		[Authorize]
		public async Task<IActionResult> Index()
		{
			var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:5001/");
			var get_batteries = await client.GetAsync($"https://rocketelevator-restapi.herokuapp.com/api/Batteries/GetByCustomer/{HttpContext.User.Identity.Name}");
			var batteries_list = JArray.Parse(await get_batteries.Content.ReadAsStringAsync());
			var batteries = new List<Battery>();
			foreach (var battery in batteries_list)
			{
				var battery_to_object = battery.ToObject<Battery>();
				batteries.Add(battery_to_object);
			}
			ViewBag.Batteries = batteries;
			return View();
		}
		[HttpGet]
		public async Task<List<long>> BatteryOfBuilding(long id)
		{
			Console.WriteLine(id);
			var client = new HttpClient();
			client.BaseAddress = new Uri("https://localhost:5001/");
			var get_batteries = await client.GetAsync($"https://rocketelevator-restapi.herokuapp.com/api/Batteries/GetByBuilding/{id}");
			var batteries_list = JArray.Parse(await get_batteries.Content.ReadAsStringAsync());
			var batteries = new List<long>();
			Console.WriteLine("parsed list");
			Console.WriteLine(batteries_list);
			foreach (var battery in batteries_list)
			{
				var battery_to_object = battery.ToObject<Battery>();
				Console.WriteLine("to object");
				Console.WriteLine(battery_to_object);
				batteries.Add(battery_to_object.Id);
			}
			
			return batteries;
		}
	}
}