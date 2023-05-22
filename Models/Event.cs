using System.ComponentModel.DataAnnotations;

namespace TakvimOdevi.Models
{
    public class Event
    {
        [Key]
        public int Id { set; get; }

        public string? Name  { get; set; }
        public string? Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }


        // location = one to many relationship
        public virtual Location? Location { get; set; }
    }
}
