using System.ComponentModel.DataAnnotations;

namespace BloodFlow.Models;

public class BloodGroup
{
    [Key]
    public int Id { get; set; }
    
    public string Name { get; set; }
    
}