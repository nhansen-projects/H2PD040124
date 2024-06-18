namespace CarAuction.Models;

public class Vehicle
{
    private int _id;
    private string _name;
    private double _km;
    private string _Regnr;
    private int _year;
    private bool _towingHook;
    private string _driversLicenseType;
    private double _engineSize;
    private double _kmPerLiter;
    private string _fuelType;
    private string _energyType;
    
    public Vehicle(int id, string name, double km, string regnr, int year, bool towingHook, string driversLicenseType, string engineSize, double kmPerLiter, string fuelType, string energyType)
    {
        _id = id;
        _name = name;
        _km = km;
        _Regnr = regnr;
        _year = year;
        _towingHook = towingHook;
        _driversLicenseType = driversLicenseType;
        _engineSize = engineSize;
        _kmPerLiter = kmPerLiter;
        _fuelType = fuelType;
        _energyType = energyType;
    }

}