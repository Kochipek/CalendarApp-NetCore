using System.ComponentModel.DataAnnotations;

namespace TakvimOdevi.Models
{
    public class Location
    {
        [Key] 
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Event>? Events { get; set; }
    }
}
