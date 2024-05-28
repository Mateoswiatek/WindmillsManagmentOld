namespace windmillsManagement.Models;

public class Windmill
{
    public Guid Guid { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public double Height { get; set; }
    public DateTime DateOfLastVisit { get; set; }
    public WindPark WindPark { get; set; }
    public ISet<Equipment.Equipment> WindmillEquipments { get; set; }
    public ISet<Visit.Visit> Visits { get; set; }
}