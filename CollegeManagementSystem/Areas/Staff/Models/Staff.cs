using CollegeManagementSystem.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CollegeManagementSystem.Areas.Staff.Models
{
    public class Staff : ApplicationUser
    {
        [Required(ErrorMessage = "Staff ID is required")]
        [RegularExpression(@"^\d{3}[A-Z]{2}$", ErrorMessage = "Staff ID must have exactly 5 characters containing 3 digits [0-9] and 2 letters [A-Z]")]
        public string StaffID { get; set; } = string.Empty;


        [Required(ErrorMessage = "Phone number is required")]
        [RegularExpression(@"^(514|438)-\d{3}-\d{4}$", ErrorMessage = "Phone number must be in Montreal format: 514-123-4567 or 438-123-4567")]
        public new string PhoneNumber { get; set; } = string.Empty;
    }
}
