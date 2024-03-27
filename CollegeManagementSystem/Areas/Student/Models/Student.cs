using CollegeManagementSystem.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace CollegeManagementSystem.Areas.Student.Models
{
    public class Student : ApplicationUser
    {
        [Required(ErrorMessage = "Student ID is required")]
        [RegularExpression(@"^\d{4}[A-Z]{2}$", ErrorMessage = "Student ID must have exactly 6 characters containing 4 digits [0-9] and 2 letters [A-Z]")]
        public string StudentID { get; set; } = string.Empty;


        [Required(ErrorMessage = "Address is required")]
        public Address? Address { get; set; }


    }

    public class Address
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Number is required")]
        public int Number { get; set; }

        [Required(ErrorMessage = "Street name is required")]
        public string StreetName { get; set; } = string.Empty;

        [Required(ErrorMessage = "City is required")]
        public string City { get; set; } = string.Empty;

        [Required(ErrorMessage = "Postal code is required")]
        [RegularExpression(@"^H[1-5|9][A|B|C|E|G|J|H|L|N|R|V|X|W|Z]$", ErrorMessage = "Invalid postal code format")]
        public string PostalCode { get; set; } = string.Empty;
    }
}
