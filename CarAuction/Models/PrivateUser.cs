namespace CarAuction.Models;

public class PrivateUser : User
{
    private string _socialSecurityNumber;
    
    public PrivateUser(int id, string name, string email, string username, string password, string socialSecurityNumber) : base(id, name, email, username, password)
    {
        this._socialSecurityNumber = socialSecurityNumber;
    }
}