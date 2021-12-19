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
  	public class ColumnController : Controller
  	{
		[Authorize]
		public async Task<IActionResult> Index()
		{
			var client = new HttpClient();
			client.BaseAddress = new Uri("https://localhost:5001/");
			var get_columns = await client.GetAsync($"https://rocketelevator-restapi.herokuapp.com/api/Columns/GetByCustomer/{HttpContext.User.Identity.Name}");
			var columns_list = JArray.Parse(await get_columns.Content.ReadAsStringAsync());
			var columns = new List<Column>();
			foreach (var column in columns_list)
			{
				var column_to_object = column.ToObject<Column>();
				columns.Add(column_to_object);
			}
			ViewBag.Columns = columns;
			return View();
		}

		[HttpGet]
		public async Task<List<long>> ColumnOfBattery(long id)
		{
			Console.WriteLine(id);
			var client = new HttpClient();
			client.BaseAddress = new Uri("https://localhost:5001/");
			var get_columns = await client.GetAsync($"https://rocketelevator-restapi.herokuapp.com/api/Columns/GetByBattery/{id}");
			var column_list = JArray.Parse(await get_columns.Content.ReadAsStringAsync());
			var columns = new List<long>();
			Console.WriteLine("parsed list");
			Console.WriteLine(column_list);
			foreach (var column in column_list)
			{
				var column_to_object = column.ToObject<Column>();
				Console.WriteLine("to object");
				Console.WriteLine(column_to_object);
				columns.Add(column_to_object.Id);
			}
			
			return columns;
		}
  	}
}