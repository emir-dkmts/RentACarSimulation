namespace RentACarSimulation.Models;

public class Color : Entity
{
    public Color()
    {
        
    }

    public Color(int id, string? name) : base(id)
    {
        name = Name;
    }
    public string? Name { get; set; }
}