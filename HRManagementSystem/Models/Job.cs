namespace HRManagementSystem.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Job")]
public class Job
{
    [Key] public int JobId { get; set; }
    [Required] [MaxLength(50)] public string Title { get; set; } = null!;
    [MaxLength(50)] public string? Description { get; set; }
}