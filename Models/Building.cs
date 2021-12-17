using System.Collections.Generic;

namespace Rocket_Elevators_Customer_Portal.Models
{
  public class Building
  {
    public long Id { get; set; }
    public int customer_id { get; set;} 
    public int address_id { get; set;}
  }
}