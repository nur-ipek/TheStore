using System;
using System.Collections.Generic;
using System.Text;

namespace TheStore.Core.Models
{
    public class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ProductType ProductType { get; set; }
        public int ProductTypeId { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public int Stock { get; set; }
        public int BodySize { get; set; }

        public int SellerId { get; set; }
        public virtual Seller Seller { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
        public int isDelete { get; set; }

    }
}
