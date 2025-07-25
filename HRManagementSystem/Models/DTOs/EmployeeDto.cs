namespace HRManagementSystem.Models.DTOs;

public class EmployeeDto
{
    public int EmployeeId { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    
    public decimal? Salary { get; set; }
    public string Email { get; set; } = null!;
    public DateTime HireDate { get; set; }
    
    public int JobId { get; set; }
    public int DepartmentId { get; set; }
    public string? JobTitle { get; set; }
    public string? DepartmentName { get; set; }
}