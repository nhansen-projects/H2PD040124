namespace CarAuction.Models;

public class Auction
{
    private int _auctionId;
    private int _vehicleId;
    private int _sellerId;
    private int _buyerId;
    private double _minimumPrice;
    
    public Auction(int auctionId, int vehicleId, int sellerId, int buyerId, double minimumPrice)
    {
        _auctionId = auctionId;
        _vehicleId = vehicleId;
        _sellerId = sellerId;
        _buyerId = buyerId;
        _minimumPrice = minimumPrice;
    }
    
}