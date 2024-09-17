using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Net_Core_API.Models;

[Table("Students")]

public class Student
{
    [Key]
    public string? StudentId { get; set; }

    public string? FullName { get; set; }
  
    public string? Address { get; set; }
}

