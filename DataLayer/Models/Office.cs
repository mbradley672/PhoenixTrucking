using System.ComponentModel.DataAnnotations;

namespace Data.Models; 

public class Office {
    [Key] public int Id { get; set; }
    [Required] public string Name { get; set; }
    [Required] public Address Address { get; set; }
    
}