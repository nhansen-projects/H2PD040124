namespace CarAuction.Models;

public class Bus : HeavyVehicle
{
    private int _numberOfSeats;
    private int _numberOfBeds;
<<<<<<< HEAD
    
 public Bus(int id, string name, double km, string regnr, int year, bool towingHook, string driversLicenseType,
     double engineSize, double kmPerLiter, string fuelType, string energyType, int heavyVehicleId, double length, 
     double height, double weight, int numberOfSeats, int numberOfBeds) 
     : base(id, name, km, regnr, year, towingHook, driversLicenseType, engineSize, kmPerLiter, fuelType, energyType, 
         heavyVehicleId, length, height, weight)
=======

    public Bus(int id, string name, double km, string regnr, int year, bool towingHook, string driversLicenseType,
        double engineSize, double kmPerLiter, string fuelType, int heavyVehicleId, double length,
        double height, double weight, int numberOfSeats, int numberOfBeds)
        : base(id, name, km, regnr, year, towingHook, driversLicenseType, engineSize, kmPerLiter, fuelType,
            heavyVehicleId, length, height, weight)
>>>>>>> f98bad2a181634e5f06f732a4743f04b03daf772
    {
        _numberOfSeats = numberOfSeats;
        _numberOfBeds = numberOfBeds;
    }
}