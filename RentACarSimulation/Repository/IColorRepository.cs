using RentACarSimulation.Models;

namespace RentACarSimulation.Repository;

public interface IColorRepository
{
    List<Color> GetAll();
    Color? GetById(int id);
    Color? Add(Color color);
    Color? Remove(int id);
    Color? Update(Color color);
}