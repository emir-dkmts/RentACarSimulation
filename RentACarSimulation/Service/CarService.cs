using RentACarSimulation.Models;
using RentACarSimulation.Models.Dtos;
using RentACarSimulation.Repository;

namespace RentACarSimulation.Service;

public class CarService
{
    private CarRepository carRepository = new CarRepository();

    public void GetAll()
    {
        List<Car> cars = carRepository.GetAll();

        foreach (Car car in cars)
        {
            Console.WriteLine(car);
        }
    }

    public void GetCarById(int id)
    {
        Car? car = carRepository.GetById(id);
        if (car is null)
        {
            Console.WriteLine("Car Not Found");
            return;
            
        }

        Console.WriteLine(car);
    }

    public void Remove(int id)
    {
        Car? deleteCar = carRepository.Remove(id);
        if (deleteCar is null)
        {
            Console.WriteLine("Car Not Found");
            return; 
        }

        Console.WriteLine(deleteCar);
    }

    public void Add(Car car)
    {
        Car created  = carRepository.Add(car);
        Console.WriteLine("Car Created");
        Console.WriteLine(created);
    }

    public void Update(Car car)
    {
        Car updated = carRepository.Update(car);
        Console.WriteLine("Car Updated");
        Console.WriteLine(updated);
    }

    public void GetDetails()
    {
        List<CarDetailDto> cars = carRepository.GetAllDetails();
        foreach (CarDetailDto carDetail in cars)
        {
            Console.WriteLine(carDetail);
        }
    }
    public void GetAllDetailsByFuelId(int fuelId)
    {
        List<CarDetailDto> details = carRepository.GetAllDetailsByFuelId(fuelId);
        details.ForEach(x => Console.WriteLine(x));
    }
    
    public void GetAllDetailsByColorId(int colorId)
    {
        List<CarDetailDto> details = carRepository.GetAllDetailsByColorId(colorId);
        details.ForEach(x => Console.WriteLine(x));
    }
    
}