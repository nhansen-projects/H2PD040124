using System.Diagnostics;

namespace CarAuction.Models;

public class PassengerCar : Vehicle
{
    private int _seats;
    private string _dimensions;
    
 public PassengerCar(int id, string name, double km, string regnr, int year, bool towingHook, string driversLicenseType, string engineSize, double kmPerLiter, string fuelType, string energyType, int seats, string dimensions) : base(id, name, km, regnr, year, towingHook, driversLicenseType, engineSize, kmPerLiter, fuelType, energyType)
    {
        this._seats = seats;
        this._dimensions = dimensions;
    }
}
