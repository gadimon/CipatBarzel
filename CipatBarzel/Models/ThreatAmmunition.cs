using System.ComponentModel.DataAnnotations;

namespace CipatBarzel.Models
{
    public class ThreatAmmunition
    {
        [Key]
        public int id { get; set; }

        public string name { get; set; }

        public int speed { get; set; }
    }
}
