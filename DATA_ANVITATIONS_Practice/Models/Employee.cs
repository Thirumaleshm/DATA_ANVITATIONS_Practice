using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace DATA_ANVITATIONS_Practice.Models
{
    public class Employee
    {
        [Required]
        [RegularExpression("^[a-zA-Z]+$")]
        public string EmployeeName { get; set; }
        [Required]

        public int EmployeeID { get; set; }
        [Required]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Please enter a valid 10-digit phone number")]
        [DataType(DataType.PhoneNumber)]
        public double ContactNumber { get; set; }

        [Required]
        [StringLength(9, MinimumLength = 3)]
        public string password { get; set; }
        [Required]
        [StringLength (9, MinimumLength = 3)]
        [Compare("password")]

        public string Conformpassword { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Only Acept Email Format")]
        public string EmailID { get; set; }

    }
}