using System;
using System.Collections.Generic;
using System.Text;

namespace TheStore.Core.Models
{
    public class ProductType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
