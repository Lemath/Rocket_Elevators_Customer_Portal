using System;
using System.ComponentModel.DataAnnotations;

namespace Rocket_Elevators_Customer_Portal.Models
{
    public class Battery
    {
        public long Id { get; set; }
        public string status { get; set; }
        public string Operation_Certificate { get; set; }
        public string Information { get; set; }
        public string Notes { get; set; }
        public int building_id { get; set; }
        public int employee_id { get; set; }
        public DateTime Last_Inspect { get; set; }

    }
}