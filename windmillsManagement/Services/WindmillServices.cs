using windmillsManagement.Models;

public class WindmillServices : IWindmillServices
{
    public Guid Save(Windmill windmill)
    {
        return Guid.NewGuid();
    }
}