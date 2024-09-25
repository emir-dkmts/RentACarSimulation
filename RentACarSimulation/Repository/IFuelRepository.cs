using RentACarSimulation.Models;

namespace RentACarSimulation.Repository;

public interface IFuelRepository
{
    List<Fuel> GetAll();
    Fuel? GetById(int id);
    Fuel? Add(Fuel fuel);
    Fuel? Remove(int id);
    Fuel? Update(Fuel fuel);
}