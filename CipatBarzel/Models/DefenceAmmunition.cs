using System.ComponentModel.DataAnnotations;

namespace CipatBarzel.Models
{
    public class DefenceAmmunition
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public int amount { get; set; }
    }
}
