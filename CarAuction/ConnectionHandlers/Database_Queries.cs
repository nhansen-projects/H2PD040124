﻿using CarAuction.Models;
using Microsoft.Data.SqlClient;
using Tmds.DBus;

namespace CarAuction.ConnectionHandlers;

public class Database_Queries
{
    // usually wouldn't use this, but due to structural changes, it's become technical debt
     // for future reference, change database class to non-static to instantiate it in mainVeiwModel
    
     public void InsertDataAuction(Auction auction)
    {
        Database.NewAuction(auction);
    }
     
    public void InsertVehicle(Vehicle vehicle)
    {
        Database.NewVehicle(vehicle);
    }
    
    public void InsertUser(User user)
    {
        Database.NewUser(user);
    }
}