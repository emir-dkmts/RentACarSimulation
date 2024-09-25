namespace RentACarSimulation.Models;

public class Transmission : Entity
{
    public Transmission()
    {
        
    }

    public Transmission(int id, string? name) : base(id)
    {
        name = Name;
    }
    public string? Name { get; set; }
}