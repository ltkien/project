using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BloodFlow.Models;

public class BloodDonationRequest: Request
{

    [Required(ErrorMessage ="This field is required")]
    public float Unit { get; set; }
    [Required(ErrorMessage ="This field is required")]
    public bool RecentSurgery { get; set; }
    [Required(ErrorMessage ="This field is required")]
    public bool Weight { get; set; }
    
    public bool NextDateAccept { get; set; }
    
    //Foreign key
    public int HospitalId { get; set; }
    public  Hospital Hospital { get; set; }
    
}