using System.ComponentModel.DataAnnotations;

namespace Data.Models; 

public class Department {
    [Key] public int Id { get; set; }
    [Required] public string DepartmentName { get; set; }
    [Required] public Office OfficeLocation { get; set; }
}