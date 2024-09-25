namespace RentACarSimulation.Models;

public class Car : Entity
{
    public Car()
    {

    }

    public Car(int id, int colorId , int fuelId, int transmissionId, string carState , int? kiloMeter,short? modelYear, string? plate,string? brandName, string? modelName, double? dailyPrice )
    {
        id = Id;
        colorId = ColorId;
        fuelId = FuelId;
        transmissionId = TransmissionId;
        carState = CarState;
        kiloMeter = KiloMeter;
        modelName = ModelName;
        modelYear = ModelYear;
        plate = Plate;
        brandName = BrandName;
        modelName = ModelName;
        dailyPrice = DailyPrice;
    }
    
    public int Id{ get; set; }
    public int ColorId { get; set; }
    public int FuelId { get; set; }
    public int TransmissionId { get; set; }
    public string CarState { get; set; }
    public int? KiloMeter { get; set; }
    public short? ModelYear { get; set; }
    public string? Plate { get; set; }
    public string? BrandName { get; set; }
    public string? ModelName { get; set; }
    public double? DailyPrice { get; set; }
}