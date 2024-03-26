using System.ComponentModel.DataAnnotations;

namespace CollegeManagementSystem.Areas.Gamer.Models
{
    public class Class
    {
        [Required(ErrorMessage = "Gamer ID is required")]
        [RegularExpression(@"^\d[A-Z]$", ErrorMessage = "Gamer ID must have exactly 2 characters containing 1 digit [0-9] and 1 letter [A-Z]")]
        public string GamerID { get; set; } = string.Empty;

        [Required(ErrorMessage = "Username is required")]
        [MaxLength(10, ErrorMessage = "Username must have a maximum length of 10 characters")]
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "Age is required")]
        [Range(18, 45, ErrorMessage = "Age must be between 18 and 45 years old")]
        public int Age { get; set; }
    }
}
