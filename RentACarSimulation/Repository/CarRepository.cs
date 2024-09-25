using RentACarSimulation.Models;
using RentACarSimulation.Models.Dtos;

namespace RentACarSimulation.Repository;

public class CarRepository : BaseRepository ,ICarRepository
{
    private List<Car> cars;
    private List<Color> colors;
    private List<Transmission> transmissions;
    private List<Fuel> fuels;

    public CarRepository()
    {
        cars = Cars();
        colors = Colors();
        fuels = Fuels();
        transmissions = Transmissions();

    }
    
    public List<Car> GetAll()
    {
        return cars;
    }

    public Car? GetById(int id)
    {
        Car? car1 = null;
        foreach (Car car in cars)
        {
            if (car.Id == id)
            {
                car1 = car;
            }
        }

        if (car1 == null)
        {
            return null;
        }

        return car1;
    }

    public Car Add(Car created)
    {
        cars.Add(created);
        return created;
    }

    public Car? Remove(int id)
    {
        Car? deletedCar = GetById(id);

        if (deletedCar is null)
        {
            return null;
        }
        cars.Remove(deletedCar);
        return deletedCar;
    }

    public Car? Update(Car car)
    {
        {
            Car? existingCar = GetById(car.Id);

            if (existingCar is null)
            {
                return null;
            }

            existingCar.ColorId = car.ColorId;
            existingCar.FuelId = car.FuelId;
            existingCar.TransmissionId = car.TransmissionId;
            existingCar.CarState = car.CarState;
            existingCar.KiloMeter = car.KiloMeter;
            existingCar.ModelName = car.ModelName;
            existingCar.ModelYear = car.ModelYear;
            existingCar.Plate = car.Plate;
            existingCar.BrandName = car.BrandName;
            existingCar.DailyPrice = car.DailyPrice;
            return existingCar;

        }

    }

    public List<CarDetailDto> GetAllDetails()
    {
        var carDetails = (from car in cars
            join color in colors on car.ColorId equals color.Id
            join fuel in fuels on car.FuelId equals fuel.Id
            join transmission in transmissions on car.TransmissionId equals transmission.Id
            select new CarDetailDto(
                car.Id,
                fuel.Name,
                transmission.Name,
                color.Name,
                car.CarState,
                car.KiloMeter,
                car.ModelYear,
                car.Plate,
                car.BrandName,
                car.ModelName,
                car.DailyPrice
            )).ToList();

        return carDetails;
    }
    
    public List<CarDetailDto> GetAllDetailsByFuelId(int fuelId)
    {
        var result =
            from car in cars
            where car.FuelId == fuelId
            join fuel in fuels on car.FuelId equals fuel.Id
            join color in colors on car.ColorId equals color.Id
            join transmission in transmissions on car.TransmissionId equals transmission.Id
            select new CarDetailDto(
                Id: car.Id,
                FuelName: fuel.Name,
                TransmissionName: transmission.Name,
                ColorName: color.Name,
                CarState: car.CarState,
                KiloMeter: car.KiloMeter,
                ModelYear: car.ModelYear,
                Plate: car.Plate,
                BrandName: car.BrandName,
                ModelName: car.ModelName,
                DailyPrice: car.DailyPrice
            );

        return result.ToList();
    }
    
    public List<CarDetailDto> GetAllDetailsByColorId(int colorId)
    {
        var result =
            from car in cars
            where car.ColorId == colorId
            join fuel in fuels on car.FuelId equals fuel.Id
            join color in colors on car.ColorId equals color.Id
            join transmission in transmissions on car.TransmissionId equals transmission.Id
            select new CarDetailDto(
                Id: car.Id,
                FuelName: fuel.Name,
                TransmissionName: transmission.Name,
                ColorName: color.Name,
                CarState: car.CarState,
                KiloMeter: car.KiloMeter,
                ModelYear: car.ModelYear,
                Plate: car.Plate,
                BrandName: car.BrandName,
                ModelName: car.ModelName,
                DailyPrice: car.DailyPrice
            );

        return result.ToList();
    }
    
    public List<CarDetailDto> GetAllDetailsByPriceRange(double min, double max)
    {
        var result =
            from car in cars
            where car.DailyPrice >= min && car.DailyPrice <= max
            join fuel in fuels on car.FuelId equals fuel.Id
            join color in colors on car.ColorId equals color.Id
            join transmission in transmissions on car.TransmissionId equals transmission.Id
            select new CarDetailDto(
                Id: car.Id,
                FuelName: fuel.Name,
                TransmissionName: transmission.Name,
                ColorName: color.Name,
                CarState: car.CarState,
                KiloMeter: car.KiloMeter,
                ModelYear: car.ModelYear,
                Plate: car.Plate,
                BrandName: car.BrandName,
                ModelName: car.ModelName,
                DailyPrice: car.DailyPrice
            );

        return result.ToList();
    }
    
    public List<CarDetailDto> GetAllDetailsByBrandNameContains(string brandName)
    {
        var result =
            from car in cars
            where car.BrandName != null && car.BrandName.Contains(brandName, StringComparison.OrdinalIgnoreCase)
            join fuel in fuels on car.FuelId equals fuel.Id
            join color in colors on car.ColorId equals color.Id
            join transmission in transmissions on car.TransmissionId equals transmission.Id
            select new CarDetailDto(
                Id: car.Id,
                FuelName: fuel.Name,
                TransmissionName: transmission.Name,
                ColorName: color.Name,
                CarState: car.CarState,
                KiloMeter: car.KiloMeter,
                ModelYear: car.ModelYear,
                Plate: car.Plate,
                BrandName: car.BrandName,
                ModelName: car.ModelName,
                DailyPrice: car.DailyPrice
            );

        return result.ToList();
    }
    
    public List<CarDetailDto> GetAllDetailsByModelNameContains(string modelName)
    {
        var result =
            from car in cars
            where car.ModelName != null && car.ModelName.Contains(modelName, StringComparison.OrdinalIgnoreCase)
            join fuel in fuels on car.FuelId equals fuel.Id
            join color in colors on car.ColorId equals color.Id
            join transmission in transmissions on car.TransmissionId equals transmission.Id
            select new CarDetailDto(
                Id: car.Id,
                FuelName: fuel.Name,
                TransmissionName: transmission.Name,
                ColorName: color.Name,
                CarState: car.CarState,
                KiloMeter: car.KiloMeter,
                ModelYear: car.ModelYear,
                Plate: car.Plate,
                BrandName: car.BrandName,
                ModelName: car.ModelName,
                DailyPrice: car.DailyPrice
            );

        return result.ToList();
    }
    public List<CarDetailDto> GetAllDetailsByKilometerRange(int min, int max)
    {
        var result =
            from car in cars
            where car.KiloMeter >= min && car.KiloMeter <= max
            join fuel in fuels on car.FuelId equals fuel.Id
            join color in colors on car.ColorId equals color.Id
            join transmission in transmissions on car.TransmissionId equals transmission.Id
            select new CarDetailDto(
                Id: car.Id,
                FuelName: fuel.Name,
                TransmissionName: transmission.Name,
                ColorName: color.Name,
                CarState: car.CarState,
                KiloMeter: car.KiloMeter,
                ModelYear: car.ModelYear,
                Plate: car.Plate,
                BrandName: car.BrandName,
                ModelName: car.ModelName,
                DailyPrice: car.DailyPrice
            );

        return result.ToList();
    }
}

