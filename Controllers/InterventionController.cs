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

namespace Rocket_Elevators_Customer_Portal.Controllers
{
  public class InterventionController : Controller
  	{
		[Authorize]
		[HttpGet]
		public IActionResult Index()
		{
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