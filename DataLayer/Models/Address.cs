using System.ComponentModel.DataAnnotations;

namespace Data.Models;

public class Address {
    [Key] public int Id { get; set; }
    [Required] public string StreetAddress { get; set; }
    public string ApartmentNumber { get; set; }
    [Required] public string City { get; set; }
    [Required] public string State { get; set; }
    [Required] public string PostalCode { get; set; }
    [Required] public string Country { get; set; }
}