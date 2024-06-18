namespace CarAuction.Models;

public class PrivateVehicle : PassengerCar
{
    private bool _isPrivate = true;
    private bool _isoFixMount;

    public PrivateVehicle(int id, string name, double km, string regnr, int year, bool towingHook,
<<<<<<< HEAD
        string driversLicenseType, double engineSize, double kmPerLiter, string fuelType, string energyType, int seats,
=======
        string driversLicenseType, double engineSize, double kmPerLiter, string fuelType, int seats,
>>>>>>> f98bad2a181634e5f06f732a4743f04b03daf772
        string dimensions, bool isoFixMount) : base(id, name, km, regnr, year, towingHook, driversLicenseType,
        engineSize, kmPerLiter, fuelType, seats, dimensions)
    {
        _isoFixMount = isoFixMount;
    }
}