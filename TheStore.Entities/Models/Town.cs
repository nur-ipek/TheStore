using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TheStore.Core.Models
{
    public class Town
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(50)]
        [Range(3, 50, ErrorMessage = "Name must be between 3 and 50 characters long.")]
        public string Name { get; set; }

        public City City { get; set; }
        public int CityId { get; set; }
    }
}
