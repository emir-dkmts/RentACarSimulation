using RentACarSimulation.Models;

namespace RentACarSimulation.Repository;

public class FuelRepository : BaseRepository , IFuelRepository
{
    private List<Fuel> fuels;
    
    public List<Fuel> GetAll()
    {
        return fuels;
    }

    public Fuel? GetById(int id)
    {
        Fuel? fuel1 = null;
        foreach (Fuel fuel in fuels)
        {
            if (fuel.Id == id)
            {
                fuel1 = fuel;
            }
        }

        if (fuel1 == null)
        {
            return null;
        }

        return fuel1;
    }

    public Fuel? Add(Fuel fuel)
    {
        fuels.Add(fuel);
        return fuel;
    }

    public Fuel? Remove(int id)
    {
        Fuel? deletedFuel = GetById(id);

        if (deletedFuel is null)
        {
            return null;
        }
        
        fuels.Remove(deletedFuel);
        return deletedFuel;
    }

    public Fuel? Update(Fuel fuel)
    {
        {

            Fuel? existingFuel = GetById(fuel.Id);

            if (existingFuel is null)
            {
                return null;
            }

            existingFuel.Name = fuel.Name;
            return existingFuel;

        }
    }
}