using RentACarSimulation.Models;

namespace RentACarSimulation.Repository;

public interface ICarRepository
{
    List<Car> GetAll();
    Car? GetById(int id);
    Car Add(Car created);
    Car? Remove(int id);
    Car? Update(Car car);
}