namespace HRManagementSystem.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Employee")]
public class Employee
{
    [Key] public int EmployeeId { get; set; }
    [Required] [MaxLength(50)] public string FirstName { get; set; } = null!;
    [Required] [MaxLength(50)] public string LastName { get; set; } = null!;
    public decimal? Salary { get; set; }
    [Required] [EmailAddress] [MaxLength(100)] public string Email { get; set; } = null!;
    [Required] public DateTime HireDate { get; set; }
    [ForeignKey("Department")] public int DepartmentId { get; set; }
    [Required] public Department Department { get; set; } = null!;
}