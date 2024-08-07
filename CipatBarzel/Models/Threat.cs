using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using CipatBarzel.Utils;

namespace CipatBarzel.Models
{
    public class Threat
    {

        public Threat()
        {
            status = ThreatStatus.Inactive;
        }

        [Key]
        public int id { get; set; }

        [NotMapped]
        public int responseTime
        { 
            get
            {
                return (Org.distance / type.speed) * 3600;
            }
                
        }

        public TerrorOrg Org { get; set; }

        public ThreatAmmunition type { get; set; }

        public ThreatStatus status { get; set; }

        public DateTime? fired_at { get; set; }

    }
}
