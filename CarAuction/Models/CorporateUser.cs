namespace CarAuction.Models;

public class CorporateUser : User
{
    private bool _isPrivate = false;
    private int _credit;
    private int _cvrNumber;

    public CorporateUser(int id, string username, string postalCode, string password, int credit, int cvrNumber) : base(id, username, postalCode, password)
    {
        _credit = credit;
        _cvrNumber = cvrNumber;
    }
}