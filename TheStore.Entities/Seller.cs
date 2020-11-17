using System;
using System.Collections.Generic;
using System.Text;

namespace TheStore.Entities
{
    public class Seller
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public string StoreName { get; set; }
        public int IdentityNumber { get; set; }
        public MembershipType MembershipType { get; set; }
        public int MembershipTypeId { get; set; }



    }
}
