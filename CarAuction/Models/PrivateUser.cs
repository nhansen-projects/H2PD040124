namespace CarAuction.Models;

public class PrivateUser : User
{
    private bool _isPrivate = true;
    private string _socialSecurityNumber;
}