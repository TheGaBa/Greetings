using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Models
{
    public class Place
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PlaceId { get; set; }

        public string PlaceName { get; set; }
        
        public double Cost { get; set; }
        
        public int Time { get; set; }

        public string Address { get; set; }
        
        public byte[] Image { get; set; }

        public string Descriprion { get; set; }

        public int CityId { get; set; }
        
        public City City { get; set; }

        public List<ImageStorage> ImageStorage { get; set; }
    }
}