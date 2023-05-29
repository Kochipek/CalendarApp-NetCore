using System.ComponentModel.DataAnnotations;

namespace TakvimOdevi.Models
{
    public class Event
    {
        [Key]
        public int Id { set; get; }

        public string Name  { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }


        // one to many relationships
        // Location ve User birden fazla nesne ile iliskilendirilecek
        public virtual Location Location { get; set; }

        public virtual User User { get; set; }

        public Event(IFormCollection form, Location location)
        {
            Id = int.Parse(form["Id"]);
            Name = form["Name"];
            Description = form["Description"];
            StartTime = DateTime.Parse(form["StartTime"]);
            EndTime = DateTime.Parse(form["EndTime"]);
            Location = location;
        }

        public void UpdateEvent(IFormCollection form, Location location)
        {
            Id = int.Parse(form["Id"]);
            Name = form["Name"];
            Description = form["Description"];
            StartTime = DateTime.Parse(form["StartTime"]);
            EndTime = DateTime.Parse(form["EndTime"]);
            Location = location;
        }

        public Event()
        {

        }
    }
}
