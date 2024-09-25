using RentACarSimulation.Models;

namespace RentACarSimulation.Repository;

public abstract class BaseRepository
{
    private List<Car> cars = new List<Car>()
    {
        new Car
        {
            Id = 1,
            BrandName = "Audi",
            CarState = "Free",
            ColorId = 1,
            DailyPrice = 50,
            FuelId = 2,
            KiloMeter = 500,
            ModelName = "CLA",
            ModelYear = 2020,
            Plate = "47 FM 2020"
            
        }
    };

    private List<Color> colors = new List<Color>()
    {
        new Color
        {
            Id = 1,
            Name = "Black"
        },
        
        new Color
        {
            Id = 2,
            Name = "Blue"
        }
    };

    private List<Fuel> fuels = new List<Fuel>()
    {
        new Fuel
        {
            Id = 1,
            Name = "Diesel"
        },
        
        new Fuel
        {
            Id = 2,
            Name = "Gasoline"
        }
    };

    private List<Transmission> transmissions = new List<Transmission>()
    {
        new Transmission
        {
            Id = 1,
            Name = "Manual"
        },
        new Transmission
        {
            Id = 2,
            Name = "Automatic"
        }
    };

    public List<Car> Cars()
    {
        return cars;
    }

    public List<Color> Colors()
    {
        return colors;
    }

    public List<Fuel> Fuels()
    {
        return fuels;
    }

    public List<Transmission> Transmissions()
    {
        return transmissions;
    }
}