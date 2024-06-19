using CarAuction.Models;

namespace CarAuction.ConnectionHandlers;

public class Database_Queries
{
    public void InsertDataAuction()
    {
        string table = "Auction";
        string[] columns = new string[] { "ID", "VehicleID", "SellerUserID", "BuyerUserID", "MinimumPrice" };
        string[] values = new string[] { {auctionId}, {vehicleId}, {sellerId}, {buyerId}, {minimumPrice} };
        Database.Insert(table, columns, values);
}