using System.ComponentModel.DataAnnotations;

namespace Data.Models;

public class CompanyPosition {
    [Key] public int Id { get; set; }
    [Required] public string Title { get; set; }
}