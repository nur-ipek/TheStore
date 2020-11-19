using System;
using System.Collections.Generic;
using System.Text;

namespace TheStore.Core.Models
{
    public class Seller
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StoreName { get; set; }
        public int PhoneNumber { get; set; }
        public string Adress { get; set; }
        public int IdentityNumber { get; set; }
        public virtual MembershipType MembershipType { get; set; }
        public int MembershipTypeId { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public Order Order { get; set; }

        public City City { get; set; }
        public int CityId { get; set; }



    }
}
