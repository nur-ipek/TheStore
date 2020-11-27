using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TheStore.Core.Models

{
    public class City
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Required")]
        [StringLength(15)]
        [Range(2,15, ErrorMessage ="City name must be between 2 and 15 characters long.")]
        public string Name { get; set; }
        public virtual ICollection<Town> Towns { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }

        public virtual ICollection<Seller> Sellers { get; set; }
    }
}
