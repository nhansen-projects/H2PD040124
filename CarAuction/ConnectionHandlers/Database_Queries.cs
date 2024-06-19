using CarAuction.Models;
using Microsoft.Data.SqlClient;
using Tmds.DBus;

namespace CarAuction.ConnectionHandlers;

public class Database_Queries
{
    public void InsertDataAuction()
    {
        string table = "Auction";
        string[] columns = new string[] { "ID", "VehicleID", "SellerUserID", "BuyerUserID", "MinimumPrice" };
        // string[] values = new string[] { { auctionId }, { vehicleId }, { sellerId }, { buyerId }, { minimumPrice } };
        // Database.Insert(table, columns, values);
    }

    public void InsertVehicle(Vehicle vehicle)
    {
        Database.OpenConnection();
        /*        string table = "Vehicle";
                string[] columns = new string[] { "Name", "Km", "Regnr", "Year", "TowingHook", "DriversLicenseType", "EngineSize", "KmPerLiter", "FuelType", "EnergyClass" };
                string[] values = new string[] { vehicle.Name ,  vehicle.Km.ToString() , vehicle.Regnr,  vehicle.Year.ToString(), vehicle.TowingHook.ToString(), vehicle.DriversLicenseType, vehicle.EngineSize.ToString(), vehicle.KmPerLiter.ToString(), vehicle.FuelType, vehicle.GetEnergyClass() };
                Database.Insert(table, columns, values);
        */
        Database.NewVehicle(vehicle);
        Database.CloseConnection();
    }
}