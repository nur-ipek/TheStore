using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TheStore.Core.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(15)]
        [Range(3, 15, ErrorMessage = "Name must be between 3 and 15 characters long.")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Required")]
        [StringLength(15)]
        [Range(3, 15, ErrorMessage = "Last name must be between 3 and 15 characters long.")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Required")]
        [StringLength(15)]
        [Range(6, 15, ErrorMessage = "Username must be between 6 and 15 characters long.")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Required")]
        [StringLength(100)]
        [Range(15, 100, ErrorMessage = "Address must be between 15 and 100 characters long.")]
        public string Address { get; set; }


        [Required(ErrorMessage = "Required")]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Wrong number.")]
        public long PhoneNumber { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Birthdate{ get; set; }
        public City City { get; set; }

        public int CityId{ get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public bool IsActive { get; set; }


    }
}
