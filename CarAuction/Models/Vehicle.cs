namespace CarAuction.Models;

public class Vehicle
{
    private int _id;
    private string _name;
    private double _km;
    private string _regnr;
    private int _year;
    private bool _towingHook;
    private string _driversLicenseType;
    private double _engineSize;
    private double _kmPerLiter;
    private string _fuelType;
    private string _energyType;

    public Vehicle(int id, string name, double km, string regnr, int year, bool towingHook, string driversLicenseType, double engineSize, double kmPerLiter, string fuelType)
    {
        _id = id;
        _name = name;
        _km = km;
        _regnr = regnr;
        _year = year;
        _towingHook = towingHook;
        _driversLicenseType = driversLicenseType;
        _engineSize = engineSize;
        _kmPerLiter = kmPerLiter;
        _fuelType = fuelType;
        _energyType = GetEnergyClass();
    }

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
        get => _regnr;
        set => _regnr = value;
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
    public double EngineSize
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
    }
    private string GetEnergyClass()
    {
        if (FuelType == "Hydrogen" || FuelType == "Electricity") return "A";

        if (Year < 2010)
        {
            if (FuelType == "Diesel")
            {
                switch (KmPerLiter)
                {
                    case >= 23:
                        return "A";
                    case >= 18:
                        return "B";
                    case >= 13:
                        return "C";
                    default:
                        return "D";
                }
            }
            else if (FuelType == "Gasoline")
            {
                switch (KmPerLiter)
                {
                    case >= 18:
                        return "A";
                    case >= 14:
                        return "B";
                    case >= 10:
                        return "C";
                    default:
                        return "D";
                }
            }
            else
            {
                return "D";
            }
        }
        else
        {
            if (FuelType == "Diesel")
            {
                switch (KmPerLiter)
                {
                    case >= 25:
                        return "A";
                    case >= 20:
                        return "B";
                    case >= 15:
                        return "C";
                    default:
                        return "D";
                }
            }
            else if (FuelType == "Gasoline")
            {
                switch (KmPerLiter)
                {
                    case >= 20:
                        return "A";
                    case >= 16:
                        return "B";
                    case >= 12:
                        return "C";
                    default:
                        return "D";
                }
            }
            else
            {
                return "D";
            }
        }
    }
}