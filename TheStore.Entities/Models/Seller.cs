using System;
using System.Collections.Generic;
using System.Text;

namespace TheStore.Core.Models
{
    public class Seller
    {

        public int Id { get; set; }
        public virtual Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public string StoreName { get; set; }
        public int IdentityNumber { get; set; }
        public virtual MembershipType MembershipType { get; set; }
        public int MembershipTypeId { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public Order Order { get; set; }



    }
}
