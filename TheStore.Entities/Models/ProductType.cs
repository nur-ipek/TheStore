using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TheStore.Core.Models
{
    public class ProductType
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(25)]
        [Range(3, 25, ErrorMessage = "Name must be between 3 and 25 characters long.")]
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
