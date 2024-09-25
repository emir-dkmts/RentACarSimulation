namespace RentACarSimulation.Models;

public class Fuel : Entity
{
    public Fuel()
    {
        
    }

    public Fuel(int id, string? name) : base(id)
    {
        name = Name;
    }
    public string? Name { get; set; }
}