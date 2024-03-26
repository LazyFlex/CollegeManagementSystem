using System.ComponentModel.DataAnnotations;

namespace CollegeManagementSystem.Areas.Student.Models
{
    public class StudentDuty
    {
        [Key]
        [Required(ErrorMessage = "Code is required")]
        [RegularExpression(@"^\d{1,2}[A-Z]{1,2}$", ErrorMessage = "Code must have exactly 4 characters containing 2 digits [0-9] and 2 letters [A-Z]")]
        public string Code { get; set; } = string.Empty;

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Status is required")]
        [EnumDataType(typeof(DutyStatus), ErrorMessage = "Invalid duty status")]
        public DutyStatus Status { get; set; }
    }
    public enum DutyStatus
    {
        Completed,
        InProgress,
        NotStarted
    }
}
