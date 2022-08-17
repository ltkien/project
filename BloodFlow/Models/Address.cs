using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BloodFlow.Models;

public class Address
{
    [Key]
    public string Id { get; set; } = null!;
    
    public string AddressNumber { get; set; } = null!;
    
    public string Street { get; set; } = null!;
    
    [Required(ErrorMessage ="This field is required")]
    public string Ward { get; set; } = null!;
    
    [Required(ErrorMessage ="This field is required")]
    public string City { get; set; } = null!;
}