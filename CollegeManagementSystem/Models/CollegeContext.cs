using CollegeManagementSystem.Areas.Identity.Data;
using CollegeManagementSystem.Areas.Staff.Models;
using CollegeManagementSystem.Areas.Student.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CollegeManagementSystem.Models
{
    public class CollegeContext : IdentityDbContext<ApplicationUser>
    {
        public CollegeContext(DbContextOptions<CollegeContext> options)
        : base(options)
        {

        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; } = null!;
        public DbSet<Student> Students { get; set; } = null!;
        public DbSet<Staff> Staff { get; set; } = null!;

        public DbSet<Gamer> Gamers { get; set; } = null!;

        public DbSet<StaffTask> StaffTasks { get; set; } = null!;

        public DbSet<StudentDuty> StudentDuties { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<StudentDuty>().HasData(
                new StudentDuty { Code = "12AB", Description = "Complete homework assignment", Status = DutyStatus.Completed },
                new StudentDuty { Code = "34CD", Description = "Study for exams", Status = DutyStatus.InProgress },
                new StudentDuty { Code = "56EF", Description = "Research project work", Status = DutyStatus.NotStarted },
                new StudentDuty { Code = "78GH", Description = "Prepare presentation", Status = DutyStatus.Completed },
                new StudentDuty { Code = "90IJ", Description = "Submit assignment", Status = DutyStatus.InProgress }
               );

            modelBuilder.Entity<StaffTask>().HasData(
               new StaffTask { TaskCode = "CS1", TaskDescription = "Introduction to Computer Science", TaskLocation = TaskLocation.Online, TaskStatus = Areas.Staff.Models.TaskStatus.Completed },
               new StaffTask { TaskCode = "DS1", TaskDescription = "Data Structures and Algorithms", TaskLocation = TaskLocation.Physical, TaskStatus = Areas.Staff.Models.TaskStatus.InProgress },
               new StaffTask { TaskCode = "DB3", TaskDescription = "Database Management Systems", TaskLocation = TaskLocation.Hybrid, TaskStatus = Areas.Staff.Models.TaskStatus.NotStarted },
               new StaffTask { TaskCode = "OS5", TaskDescription = "Operating Systems", TaskLocation = TaskLocation.Online, TaskStatus = Areas.Staff.Models.TaskStatus.Completed },
               new StaffTask { TaskCode = "SE9", TaskDescription = "Software Engineering", TaskLocation = TaskLocation.Physical, TaskStatus = Areas.Staff.Models.TaskStatus.InProgress }
               );
            modelBuilder.Entity<ApplicationUser>(entity =>
            {
                entity.ToTable("ApplicationUsers");
                modelBuilder.Entity<Student>(entity =>
                {
                    entity.ToTable("Students");
                    modelBuilder.Entity<Staff>(entity =>
                    {
                        entity.ToTable("Staff");
                    });

                });
            });
        }
    }
}
