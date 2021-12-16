using System.Collections.Generic;

namespace Rocket_Elevators_Customer_Portal.Models
{
    public class Customer
    {
        public long Id { get; set; }
        public string company_name { get; set; }
        public string company_contact { get; set; }
        public string company_email { get; set; }
        public long address_id { get; set; }
        
    }
}