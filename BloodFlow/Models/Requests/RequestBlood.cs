using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BloodFlow.Models;

public class RequestBlood: Request
{
    public float Unit { get; set; }
    
    //Fk
    public int BloodGroupId { get; set; }
    public BloodGroup BloodGroup { get; set; }
}