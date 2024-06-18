namespace CarAuction.Models;

public class Bus : HeavyVehicle
{
    private int _numberOfSeats;
    private int _numberOfBeds;

    public Bus(int id, string name, double km, string regnr, int year, bool towingHook, string driversLicenseType,
        double engineSize, double kmPerLiter, string fuelType, int heavyVehicleId, double length,
        double height, double weight, int numberOfSeats, int numberOfBeds)
        : base(id, name, km, regnr, year, towingHook, driversLicenseType, engineSize, kmPerLiter, fuelType,
            heavyVehicleId, length, height, weight)
    {
        _numberOfSeats = numberOfSeats;
        _numberOfBeds = numberOfBeds;
    }
}