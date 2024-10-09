using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace EMSMvc.Models
{
    public class Employee
    {
        public Int32 EmployeeID { get; set; }
        [Display(Name = " FirstName")]
        [Required(ErrorMessage="Enter First Name")]
        public string FirstName { get; set; }
        [Display(Name = " LastName")]
        [Required(ErrorMessage = "Enter Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Position")]
        [Required(ErrorMessage = "Enter your Position")]
        public string Position { get; set; }
        [Display(Name = "Age")]
        [Required(ErrorMessage = "Enter Your Age")]
        public Nullable<int> Age { get; set; }
        [Display(Name = "Salary")]
        [Required(ErrorMessage = "Enter Your Salary")]
        public Nullable<int> Salary { get; set; }

    }
}