using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TheStore.Core.Models
{
    public class Product
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(100)]
        [Range(5, 70, ErrorMessage = "Name must be between 5 and 70 characters long.")]
        public string Name { get; set; }
        public virtual ProductType ProductType { get; set; }
        public int? ProductTypeId { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(100)]
        [Range(15, 100, ErrorMessage = "Description must be between 15 and 100 characters long.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Required")]
        public decimal UnitPrice { get; set; }

        [Required(ErrorMessage = "Required")]
        public int Stock { get; set; }

        [Required(ErrorMessage = "Required")]
        public int BodySize { get; set; }

        public int? SellerId { get; set; }
        public virtual Seller Seller { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }

        [Required(ErrorMessage = "Required")]
        public bool IsDelete { get; set; }

    }
}
