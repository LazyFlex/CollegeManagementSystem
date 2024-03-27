using CollegeManagementSystem.Areas.Student.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CollegeManagementSystem.Models
{
    public class ApplicationUser: IdentityUser
    {
        [Required(ErrorMessage = "Name is required")]
        [RegularExpression(@"^[A-Za-z]{1,15}$", ErrorMessage = "Name must contain only letters and have a maximum length of 15 characters")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Surname is required")]
        [RegularExpression(@"^[A-Za-z]{1,15}$", ErrorMessage = "Surname must contain only letters and have a maximum length of 15 characters")]
        public string Surname { get; set; } = string.Empty;
        
    }
}
