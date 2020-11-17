using System;
using System.Collections.Generic;
using System.Text;

namespace TheStore.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public Seller Seller { get; set; }
        public int SellerId { get; set; }
        public DateTime OrderedDate { get; set; }
    }
}
