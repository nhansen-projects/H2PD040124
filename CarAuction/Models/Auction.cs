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
    public Auction()
    {
        _auctionId = 0;
        _vehicleId = 0;
        _sellerId = 0;
        _buyerId = 0;
        _minimumPrice = 0;
    }
    public int AuctionId
    {
        get => _auctionId;
        set => _auctionId = value;
    }
    public int VehicleId
    {
        get => _vehicleId;
        set => _vehicleId = value;
    }
    public int SellerId
    {
        get => _sellerId;
        set => _sellerId = value;
    }
    public int BuyerId
    {
        get => _buyerId;
        set => _buyerId = value;
    }
    public double MinimumPrice
    {
        get => _minimumPrice;
        set => _minimumPrice = value;
    }
}