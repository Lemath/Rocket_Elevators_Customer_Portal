using System;

namespace Rocket_Elevators_Customer_Portal.Models
{
  public class Intervention
  {
        public long Id { get; set; }
        public long author_id { get; set; }
        public long customer_id { get; set; }
        public long building_id { get; set; }
        public long battery_id { get; set; }
        public Nullable<long> column_id { get; set; }
        public Nullable<long> elevator_id { get; set; }
        public Nullable<long> employee_id { get; set; }
        public Nullable<DateTime> Start { get; set; }
        public Nullable<DateTime> End { get; set; }
        public string Result { get; set; }
        public string Report { get; set; }
        public string Status { get; set; }
  }
}