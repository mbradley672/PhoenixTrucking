using System;
using System.ComponentModel.DataAnnotations;

namespace Data.Models;

public class Employee {
    public int Id { get; set; }
    [Required] public string FirstName { get; set; }
    public string MiddleName { get; set; }
    [Required] public string LastName { get; set; }
    [Required] public Address Address { get; set; }
    [Required] public Company Company { get; set; }
    [Required] public CompanyPosition Position { get; set; }
    [Required] public decimal PayRate { get; set; }
    [Required] public PayType PayType { get; set; }
    [Required] public DateTime DateHired { get; set; }
    public DateTime DateInPosition { get; set; }
    [Required] public Department Department { get; set; }

}