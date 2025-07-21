using HRManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace HRManagementSystem.Data;

public class DatabaseContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Job> Jobs { get; set; }
    
    public DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Job>().HasData(
            new Job
            {
                JobId = 1,
                Title = "Manager",
                Description = "Manages work of subordinates within department."
            },
            new Job
            {
                JobId = 2,
                Title = "Software Developer",
                Description = "Develops and maintains software systems."
            },
            new Job
            {
                JobId = 3,
                Title = "HR Specialist",
                Description = "Handles recruitment and employee relations." });
        modelBuilder.Entity<Department>().HasData(
            new Department
            {
                DepartmentId = 1,
                Name = "IT",
                Location = "Main Office"
            },
            new Department
            {
                DepartmentId = 2,
                Name = "Human Resources",
                Location = "Building B"
            },
            new Department
            {
                DepartmentId = 3,
                Name = "Marketing",
                Location = "Building C"
            });
        modelBuilder.Entity<Employee>().HasData(
            new Employee
            {
                EmployeeId = 1,
                FirstName = "John",
                LastName = "Doe",
                Salary = 1500.00m,
                Email = "mngr_john@gmail.com",
                HireDate = new DateTime(2023, 5, 10),
                DepartmentId = 1,
                JobId = 2
            },
            new Employee
            {
                EmployeeId = 2,
                FirstName = "Jane",
                LastName = "Smith",
                Salary = 2000.00m,
                Email = "janesmith@yahoo.com",
                HireDate = new DateTime(2022, 9, 1),
                DepartmentId = 1,
                JobId = 1
            },
            new Employee
            {
                EmployeeId = 3,
                FirstName = "Alice",
                LastName = "Johnson",
                Salary = 1800.00m,
                Email = "johnson89@gmail.com",
                HireDate = new DateTime(2024, 3, 15),
                DepartmentId = 2,
                JobId = 3
            });
    }
}