namespace HRManagementSystem.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Department")]
public class Department
{
    [Key] public int DepartmentId { get; set; }
    [Required] [MaxLength(50)] public string Name { get; set; } = null!;
    [Required] [MaxLength(50)] public string Location { get; set; } = null!;
    public ICollection<Employee> Employees { get; set; } = new List<Employee>();
}