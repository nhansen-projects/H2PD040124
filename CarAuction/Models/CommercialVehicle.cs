using System.Globalization;

namespace CarAuction.Models;

public class CommercialVehicle : PassengerCar
{
    private bool _safetyBar;

    public CommercialVehicle(int id, string name, double km, string regnr, bool towingHook,
<<<<<<< HEAD
        string driversLicenseType, double engineSize, double kmPerLiter, string energyType, int seats,
        string dimensions, bool isoFixMount,  string brand, string model, int year, string fuelType, double price, int numberOfSeats, bool safetyBar) 
        : base( id,  name,  km,  regnr, year,  towingHook,  driversLicenseType, engineSize,  kmPerLiter,  fuelType,  energyType,  seats,  dimensions)
=======
        string driversLicenseType, double engineSize, double kmPerLiter, int seats,
        string dimensions, bool isoFixMount, string brand, string model, int year, string fuelType, double price, int numberOfSeats, bool safetyBar)
        : base(id, name, km, regnr, year, towingHook, driversLicenseType, engineSize, kmPerLiter, fuelType, seats, dimensions)
>>>>>>> f98bad2a181634e5f06f732a4743f04b03daf772
    {
        _safetyBar = safetyBar;
    }
}