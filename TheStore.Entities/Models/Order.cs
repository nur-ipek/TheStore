using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TheStore.Core.Models
{
    public class Order
    {
        public int Id { get; set; }
        public virtual Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public virtual Seller Seller { get; set; }

        public int? SellerId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime OrderedDate { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
