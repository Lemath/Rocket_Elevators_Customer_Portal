using System.Collections.Generic;

namespace Rocket_Elevators_Customer_Portal.Models
{
  public class Column
  {
    public long Id { get; set; }
    public string status { get; set; }
    public string type_of_building { get; set; }
    public int number_of_floors_served { get; set; }
    public string information { get; set; }
    public string notes { get; set; }
    public int battery_id { get; set; }
  }
}