using Microsoft.AspNetCore.Identity;

namespace TakvimOdevi.Models
{
    public class User: IdentityUser
    {
        public virtual ICollection<Event> Events { get; set; }
    }
}
