using RentACarSimulation.Models;

namespace RentACarSimulation.Repository;

public interface ITransmissionRepository
{
    List<Transmission> GetAll();
    Transmission? GetById(int id);
    Transmission? Add(Transmission transmission);
    Transmission? Remove(int id);
    Transmission? Update(Transmission transmission);
}