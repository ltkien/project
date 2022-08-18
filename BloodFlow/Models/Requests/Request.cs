using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BloodFlow.Models;

public class Request
{
    //random
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Id { get; set; } = null!;
    public DateTime Date { get; set; }
    //FK
    public int HospitalId { get; set; }
    public  Hospital Hospital { get; set; }

}