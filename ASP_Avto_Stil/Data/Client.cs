using Microsoft.AspNetCore.Identity;

namespace ASP_Avto_Stil.Data
{
    public class Client:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime RegisterOn { get; set; }    
        public ICollection<Order> Orders { get; set; }
    }
}
