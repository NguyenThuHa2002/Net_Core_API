using System.ComponentModel.DataAnnotations;
namespace Net_Core_API.Models;

public class Student
{
    public string? ID { get; set; }

    public string? Fullname { get; set; }
    public string? Age { get; set; }
    public string? Address { get; set; }
}