using HRManagementSystem.Models.DTOs;

namespace HRManagementSystem.Services;

public interface IEmployeeService
{
    public Task<EmployeeDto> GetEmployeeById(int employeeId);
}