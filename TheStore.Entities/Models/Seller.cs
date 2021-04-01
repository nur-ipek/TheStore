using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TheStore.Core.Models
{
    public class Seller
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(15)]
        [Range(3, 15, ErrorMessage = "First name must be between 3 and 15 characters long.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(15)]
        [Range(3, 15, ErrorMessage = "Last name must be between 3 and 15 characters long.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(15)]
        [Range(3, 15, ErrorMessage = "Name must be between 3 and 15 characters long.")]
        public string StoreName { get; set; }

        [Required(ErrorMessage = "Required")]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Wrong number.")]
        public long PhoneNumber { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(100)]
        [Range(15, 100, ErrorMessage = "Address must be between 15 and 100 characters long.")]
        public string Adress { get; set; }

        [MaxLength(11), MinLength(11)]
        public long IdentityNumber { get; set; }
        public virtual MembershipType MembershipType { get; set; }

        public int MembershipTypeId { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public Order Order { get; set; }

        public City City { get; set; }

        public int CityId { get; set; }



    }
}
