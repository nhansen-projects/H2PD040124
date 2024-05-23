using System.Diagnostics;

namespace CarAuction.Models;

public class PassengerCar : Vehicle
{
    private int _seats;
    private string _dimensions;
    
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
