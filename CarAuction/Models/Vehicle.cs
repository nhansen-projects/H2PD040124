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
    private string _engineSize;
    private double _kmPerLiter;
    private string _fuelType;
    private string _energyType;
    
    public int Id
    {
        get => _id;
        set => _id = value;
    }
    public string Name
    {
        get => _name;
        set => _name = value;
    }
    public double Km
    {
        get => _km;
        set => _km = value;
    }
    public string Regnr
    {
        get => _Regnr;
        set => _Regnr = value;
    }
    public int Year
    {
        get => _year;
        set => _year = value;
    }
    public bool TowingHook
    {
        get => _towingHook;
        set => _towingHook = value;
    }
    public string DriversLicenseType
    {
        get => _driversLicenseType;
        set => _driversLicenseType = value;
    }
    public string EngineSize
    {
        get => _engineSize;
        set => _engineSize = value;
    }
    public double KmPerLiter
    {
        get => _kmPerLiter;
        set => _kmPerLiter = value;
    }
    public string FuelType
    {
        get => _fuelType;
        set => _fuelType = value;
    }
    public string EnergyType
    {
        get => _energyType;
        set => _energyType = value;
    }
    
}