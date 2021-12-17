using System;
using System.Collections.Generic;

namespace Rocket_Elevators_Customer_Portal.Models
{
  public class Elevator
  {
    public long Id { get; set; }
    public string status { get; set; }
    public int serial_number { get; set; }
    public string model { get; set; } 
    public string type_of_building { get; set; }
    public DateTime date_of_commissioning { get; set; } 
    public DateTime date_of_last_inspection { get; set; }
    public string certificate_of_inspection { get; set; }
    public string information { get; set; }
    public string notes { get; set; }
    public int column_id { get; set; }
  }
}