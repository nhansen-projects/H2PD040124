namespace CarAuction.Models;

public class HeavyVehicle : Vehicle
{
    private int _heavyVehicleId;
    private double _length;
    private double _height;
    private double _weight;

    public HeavyVehicle(int id, string name, double km, string regnr, int year, bool towingHook, string driversLicenseType, double engineSize, double kmPerLiter, string fuelType, string energyType, int heavyVehicleId, double length, double height, double weight) : base(id, name, km, regnr, year, towingHook, driversLicenseType, engineSize, kmPerLiter, fuelType, energyType)
    {
        _heavyVehicleId = heavyVehicleId;
        _length = length;
        _height = height;
        _weight = weight;
    }
}