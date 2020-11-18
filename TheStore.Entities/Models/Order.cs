using System;
using System.Collections.Generic;
using System.Text;

namespace TheStore.Core.Models
{
    public class Order
    {
        public int Id { get; set; }
        public virtual Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public virtual Seller Seller { get; set; }
        public int SellerId { get; set; }
        public DateTime OrderedDate { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
