using System.ComponentModel.DataAnnotations;

namespace CollegeManagementSystem.Areas.Staff.Models
{
    public class Staff
    {
        [Required(ErrorMessage = "Staff ID is required")]
        [RegularExpression(@"^\d{3}[A-Z]{2}$", ErrorMessage = "Staff ID must have exactly 5 characters containing 3 digits [0-9] and 2 letters [A-Z]")]
        public string StaffID { get; set; } = string.Empty;

        [Required(ErrorMessage = "Name is required")]
        [RegularExpression(@"^[A-Za-z]{1,15}$", ErrorMessage = "Name must contain only letters and have a maximum length of 15 characters")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Surname is required")]
        [RegularExpression(@"^[A-Za-z]{1,15}$", ErrorMessage = "Surname must contain only letters and have a maximum length of 15 characters")]
        public string Surname { get; set; } = string.Empty;

        [Required(ErrorMessage = "Phone number is required")]
        [RegularExpression(@"^(514|438)-\d{3}-\d{4}$", ErrorMessage = "Phone number must be in Montreal format: 514-123-4567 or 438-123-4567")]
        public string PhoneNumber { get; set; } = string.Empty;
    }
}
