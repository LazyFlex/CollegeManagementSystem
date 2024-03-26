using System.ComponentModel.DataAnnotations;

namespace CollegeManagementSystem.Areas.Staff.Models
{
    public class StaffTask
    {
        [Key]
        [Required(ErrorMessage = "Task code is required")]
        [RegularExpression(@"^[A-Z]*\d[A-Z]*$", ErrorMessage = "Task code must have exactly 3 characters containing 1 digit [0-9] and 2 letters [A-Z]")]
        public string TaskCode { get; set; } = string.Empty;

        [Required(ErrorMessage = "Task description is required")]
        public string TaskDescription { get; set; } = string.Empty;

        [Required(ErrorMessage = "Task location is required")]
        [EnumDataType(typeof(TaskLocation), ErrorMessage = "Invalid task location")]
        public TaskLocation TaskLocation { get; set; }

        [Required(ErrorMessage = "Task status is required")]
        [EnumDataType(typeof(TaskStatus), ErrorMessage = "Invalid task status")]
        public TaskStatus TaskStatus { get; set; }


    }

    public enum TaskLocation
    {
        Online,
        Physical,
        Hybrid
    }

    public enum TaskStatus
    {
        Completed,
        InProgress,
        NotStarted
    }
}

