using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace BloodFlow.Models;

public class User : IdentityUser
{

    // [Required(ErrorMessage ="This field is required")]
    [StringLength(50)] 
    public string? FullName { get; set; } = null!;
    
    //[Required(ErrorMessage ="You need add your phone number")]
    [StringLength(15)]
    [DataType(DataType.PhoneNumber)]
    public override string? PhoneNumber { get; set; } = null!;
    
    [Required(ErrorMessage ="Tell me about your age")]
    public DateTime DateOfBirth { get; set; }
    
    
    [Required(ErrorMessage ="This field is required")]
    [StringLength(15)]
    public override string Email { get; set; } = null!;
    
    // [Required(ErrorMessage ="This field is required")]
    [StringLength(20)]
    public string? IdCard { get; set; } = null;
    
    [Required(ErrorMessage ="This field is required")]
    public float Weight { get; set; } 
    
    public DateTime NextDateAccept { get; set; }
    
     
    
    // FK
    public string? AddressId { get; set; }
    public Address? Address { get; set; }
    public int? BloodGroupId { get; set; }
    public BloodGroup? BloodGroup { get; set; }
    public int? GenderId { get; set; } = null;
    public Gender? Gender { get; set; }
}
