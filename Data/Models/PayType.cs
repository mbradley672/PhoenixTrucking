using System.ComponentModel.DataAnnotations;

namespace Data.Models;

public class PayType {
    [Key] public int Id { get; set; }
    [Required] public string PayTypeTitle { get; set; }
    
}