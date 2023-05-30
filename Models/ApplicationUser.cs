using Microsoft.AspNetCore.Identity;

namespace TakvimOdevi.Models
{
    public class ApplicationUser: IdentityUser
    {
        public virtual ICollection<Event> Events { get; set; }
    }
}
