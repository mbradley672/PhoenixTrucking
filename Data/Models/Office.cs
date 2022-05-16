using System.ComponentModel.DataAnnotations;

namespace Data.Models; 

public class Office {
    [Key] public int Id { get; set; }
    [Required] public string Name { get; set; }
    [Required] public string Address { get; set; }
    [Required] public string City { get; set; }
    [Required] public string State { get; set; }
    [Required] public string PostalCode { get; set; }
    [Required] public string Country { get; set; }
}