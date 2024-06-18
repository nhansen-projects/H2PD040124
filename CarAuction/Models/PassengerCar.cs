using System.Diagnostics;

namespace CarAuction.Models;

public class PassengerCar : Vehicle
{
    private int _seats;
    private string _dimensions;
<<<<<<< HEAD
    
 public PassengerCar(int id, string name, double km, string regnr, int year, bool towingHook, string driversLicenseType, double engineSize, double kmPerLiter, string fuelType, string energyType, int seats, string dimensions) : base(id, name, km, regnr, year, towingHook, driversLicenseType, engineSize, kmPerLiter, fuelType, energyType)
=======

    public PassengerCar(int id, string name, double km, string regnr, int year, bool towingHook, string driversLicenseType, double engineSize, double kmPerLiter, string fuelType, int seats, string dimensions) : base(id, name, km, regnr, year, towingHook, driversLicenseType, engineSize, kmPerLiter, fuelType)
>>>>>>> f98bad2a181634e5f06f732a4743f04b03daf772
    {
        this._seats = seats;
        this._dimensions = dimensions;
    }
    public int Seats
    {
        get => _seats;
        set => _seats = value;
    }
    public string Dimensions
    {
        get => _dimensions;
        set => _dimensions = value;
    }
}
