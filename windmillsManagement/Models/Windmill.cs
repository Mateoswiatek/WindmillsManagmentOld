using System.ComponentModel.DataAnnotations;

namespace windmillsManagement.Models;

public class Windmill
{
    public Guid Guid { get; set; }
    [Required(ErrorMessage = "Podaj nazwę / oznaczenie wiatraka!")]
    public string Name { get; set; }
    public string Description { get; set; }
    [Required]
    public double Latitude { get; set; }
    [Required]
    public double Longitude { get; set; }
    public double Height { get; set; }
    public DateTime DateOfLastVisit { get; set; }
    public WindPark WindPark { get; set; }
    public ISet<Equipment.Equipment> WindmillEquipments { get; set; }
    public ISet<Visit.Visit> Visits { get; set; }
}