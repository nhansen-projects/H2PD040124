﻿namespace CarAuction.Models;

public class Truck : HeavyVehicle
{
    private int _loadCapacity; //double?
    
    public Truck(int id, string name, double km, string regnr, int year, bool towingHook, string driversLicenseType, string engineSize, double kmPerLiter, string fuelType, string energyType, int heavyVehicleId, double length, double height, double weight, int loadCapacity) : base(id, name, km, regnr, year, towingHook, driversLicenseType, engineSize, kmPerLiter, fuelType, energyType, heavyVehicleId, length, height, weight)
    {
        _loadCapacity = loadCapacity;
    }
}