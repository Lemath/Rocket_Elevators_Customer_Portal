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
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections;

namespace Rocket_Elevators_Customer_Portal.Controllers
{
  	public class InterventionController : Controller
  	{
		[Authorize]
		[HttpGet]
		public async Task<IActionResult> Index()
		{
			HttpClient client = new HttpClient();
			client.BaseAddress = new Uri("https://localhost:5001/");
			var customer_response = await client.GetAsync($"https://rocketelevator-restapi.herokuapp.com/api/Customers/{HttpContext.User.Identity.Name}");
			var customer = JArray.Parse(await customer_response.Content.ReadAsStringAsync());
			var customer_id = customer[0]["id"];
			var buildings_response = await client.GetAsync($"https://rocketelevator-restapi.herokuapp.com/api/Buildings/GetByCustomer/{customer_id}");
			var buildings_list = JArray.Parse(await buildings_response.Content.ReadAsStringAsync());
			var buildings = new List<long>();
			foreach (var building in buildings_list)
			{
				var building_to_object = building.ToObject<Building>();
				buildings.Add(building_to_object.Id);
			}
			var employees_list_response = await client.GetAsync($"https://rocketelevator-restapi.herokuapp.com/api/Employees");
			var employees_list = JArray.Parse(await employees_list_response.Content.ReadAsStringAsync());
			IEnumerable<object> employees = Enumerable.Empty<object>();;
			foreach (var employee in employees_list)
			{
				var employee_to_object = employee.ToObject<Employee>();
				employees = employees.Concat(new)
				employees.Add(employee_to_object.id);
				(employee_to_object.first_name + ' ' + employee_to_object.last_name);
			}
			ViewData["id"] = customer_id;
			ViewBag.building_id = new SelectList(buildings);
			ViewBag.employees_id = new SelectList(employees_id);
			ViewBag.employees_name = new SelectList(employees_name);
			return View();
		}

		[Authorize]
		[HttpPost]
		public async Task<IActionResult> Index(
			long author_id, 
			long customer_id, 
			long building_id, 
			long battery_id, 
			long column_id, 
			long elevator_id, 
			long employee_id, 
			DateTime start,
			DateTime end,
			string result,
			string description,
			string status
		)
		{	
			HttpClient client = new HttpClient();
			client.BaseAddress = new Uri("https://localhost:5001/");
			Intervention intervention = new Intervention(
				author_id,
				customer_id,
				building_id,
				battery_id,
				column_id,
				elevator_id,
				employee_id,
				start,
				end,
				result,
				description,
				status
			);
			
			var response = await client.PostAsJsonAsync($"https://rocketelevator-restapi.herokuapp.com/api/Interventions/CustomerInterventionRequest", intervention);
			Console.WriteLine(response.IsSuccessStatusCode);
			if (response.IsSuccessStatusCode)
			{
				return View();
			}
			else
			{
				return BadRequest();
			}
			 
		}
	}
}