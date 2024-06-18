namespace CarAuction.Models;

public class PrivateVehicle : PassengerCar
{
    private bool _isPrivate = true;
    private bool _isoFixMount;

    public PrivateVehicle(int id, string name, double km, string regnr, int year, bool towingHook,
        string driversLicenseType, double engineSize, double kmPerLiter, string fuelType, string energyType, int seats,
        string dimensions, bool isoFixMount) : base(id, name, km, regnr, year, towingHook, driversLicenseType,
        engineSize, kmPerLiter, fuelType, energyType, seats, dimensions)
    {
        _isoFixMount = isoFixMount;
    }
}