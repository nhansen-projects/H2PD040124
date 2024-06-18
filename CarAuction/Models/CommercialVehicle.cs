using System.Globalization;

namespace CarAuction.Models;

public class CommercialVehicle : PassengerCar
{
    private bool _safetyBar;

    public CommercialVehicle(int id, string name, double km, string regnr, bool towingHook,
        string driversLicenseType, double engineSize, double kmPerLiter, string energyType, int seats,
        string dimensions, bool isoFixMount, string brand, string model, int year, string fuelType, double price, int numberOfSeats, bool safetyBar)
        : base(id, name, km, regnr, year, towingHook, driversLicenseType, engineSize, kmPerLiter, fuelType, energyType, seats, dimensions)
    {
        _safetyBar = safetyBar;
    }
}