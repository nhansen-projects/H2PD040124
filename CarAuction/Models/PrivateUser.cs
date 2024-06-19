namespace CarAuction.Models;

public class PrivateUser : User
{
    private string _socialSecurityNumber;
    
    public PrivateUser(int id, string username, string postalCode, string password, string socialSecurityNumber) : base(id, username, postalCode, password)
    {
        this._socialSecurityNumber = socialSecurityNumber;
    }
}