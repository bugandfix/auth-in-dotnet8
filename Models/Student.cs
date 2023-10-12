using System.ComponentModel.DataAnnotations;

namespace AuthinDotNet8.Models;

public class Student
{
    [Key]
    public int ID { get; set; }

    public string? Name { get; set; }

    public string? Family { get; set; }

    public string? Phone { get; set; }

    public string? Address { get; set; }
}
