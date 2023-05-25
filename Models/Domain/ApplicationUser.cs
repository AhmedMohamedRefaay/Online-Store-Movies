using Microsoft.AspNetCore.Identity;

namespace Online__Store_Movies.Models.Domain
{
    public class ApplicationUser:IdentityUser
    {
        public string Name { get; set; }
    }
}
