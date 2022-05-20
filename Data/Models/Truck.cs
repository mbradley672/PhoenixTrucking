using System.ComponentModel.DataAnnotations;

namespace Data.Models; 

public class Truck {
    [Key]
    public int Id { get; set; }
    public Employee Driver { get; set; }
    [Required] public string UnitNumber { get; set; }
    public string VinNumber { get; set; }
    [Required] public int Year { get; set; }
    [Required] public string Make { get; set; }
    [Required] public string Model { get; set; }
    [Required] public int Mileage { get; set; }
    public string LastKnownLocation { get; set; }
    [Required] public DateTime DateCommissioned { get; set; }
    public DateTime DateDecommissioned { get; set; }
    // public ICollection<MaintinaceRecord> MaintinaceRecords { get; set; }

}