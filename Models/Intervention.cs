using System;
using System.ComponentModel.DataAnnotations;

namespace Rocket_Elevators_Customer_Portal.Models
{
	public class Intervention
	{
		public Intervention(
			long _author_id, 
			long _customer_id, 
			long _building_id, 
			long _battery_id, 
			long _column_id, 
			long _elevator_id, 
			long _employee_id, 
			DateTime _start, 
			DateTime _end, 
			string _result, 
			string _report, 
			string _status
		)
		{
			author_id = _author_id;
			customer_id = _customer_id;
			building_id = _building_id;
			battery_id = _battery_id;
			column_id = _column_id;
			elevator_id = _elevator_id;
			employee_id = _employee_id;
			start = _start;
			end = _end;
			result = _result;
			report = _report;
			status = _status;
		}
		public long id { get; set; }
		[Required]
		public long author_id { get; set; }
		[Required]
		public long customer_id { get; set; }
		[Required]
		public long building_id { get; set; }
		[Required]
		public long battery_id { get; set; }
		public Nullable<long> column_id { get; set; }
		public Nullable<long> elevator_id { get; set; }
		public Nullable<long> employee_id { get; set; }
		public Nullable<DateTime> start { get; set; }
		public Nullable<DateTime> end { get; set; }
		public string result { get; set; }
		[Required]
		public string report { get; set; }
		public string status { get; set; }
	}
}