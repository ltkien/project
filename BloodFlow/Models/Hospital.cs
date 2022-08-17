using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BloodFlow.Models;

public class Hospital
{
    [Key]
    
    public int Id { get; set; }
    
    [StringLength(1000)] 
    public string Fullname { get; set; } = null!;
    
    //Fk
    public string AddressId { get; set; }
    public Address Address { get; set; }
}