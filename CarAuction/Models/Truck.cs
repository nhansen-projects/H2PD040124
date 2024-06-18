namespace CarAuction.Models;

public class Truck : HeavyVehicle
{
    private int _loadCapacity; //double?
<<<<<<< HEAD
    
    public Truck(int id, string name, double km, string regnr, int year, bool towingHook, string driversLicenseType, double engineSize, double kmPerLiter, string fuelType, string energyType, int heavyVehicleId, double length, double height, double weight, int loadCapacity) : base(id, name, km, regnr, year, towingHook, driversLicenseType, engineSize, kmPerLiter, fuelType, energyType, heavyVehicleId, length, height, weight)
=======

    public Truck(int id, string name, double km, string regnr, int year, bool towingHook, string driversLicenseType, double engineSize, double kmPerLiter, string fuelType, int heavyVehicleId, double length, double height, double weight, int loadCapacity) : base(id, name, km, regnr, year, towingHook, driversLicenseType, engineSize, kmPerLiter, fuelType, heavyVehicleId, length, height, weight)
>>>>>>> f98bad2a181634e5f06f732a4743f04b03daf772
    {
        _loadCapacity = loadCapacity;
    }
}