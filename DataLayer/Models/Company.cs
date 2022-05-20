using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data.Models; 

public class Company {
    [Key] public int Id { get; set; }
    [Required] public string Name { get; set; }
    [Required] public Address Address { get; set; }
    [Required] public string UsDotNumber { get; set; }
    [Required] public string McNumber { get; set; }

    [Required] public string PhoneNumber { get; set; }
    public ICollection<Employee> CompanyContact { get; set; }
}