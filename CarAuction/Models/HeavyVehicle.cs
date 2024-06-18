namespace CarAuction.Models;

public class HeavyVehicle : Vehicle
{
    private int _heavyVehicleId;
    private double _length;
    private double _height;
    private double _weight;
<<<<<<< HEAD
    
    public HeavyVehicle(int id, string name, double km, string regnr, int year, bool towingHook, string driversLicenseType, double engineSize, double kmPerLiter, string fuelType, string energyType, int heavyVehicleId, double length, double height, double weight) : base(id, name, km, regnr, year, towingHook, driversLicenseType, engineSize, kmPerLiter, fuelType, energyType)
=======

    public HeavyVehicle(int id, string name, double km, string regnr, int year, bool towingHook, string driversLicenseType, double engineSize, double kmPerLiter, string fuelType, int heavyVehicleId, double length, double height, double weight) : base(id, name, km, regnr, year, towingHook, driversLicenseType, engineSize, kmPerLiter, fuelType)
>>>>>>> f98bad2a181634e5f06f732a4743f04b03daf772
    {
        _heavyVehicleId = heavyVehicleId;
        _length = length;
        _height = height;
        _weight = weight;
    }
}