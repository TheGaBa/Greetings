using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Models
{
    public class City
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CityId { get; set; }

        public string CityName { get; set; }

        public byte[] Image { get; set; }

        public string Rating { get; set; }

        [DefaultValue(false)]
        public bool Like { get; set; }

        public List<Place> Places { get; set; }
    }
}