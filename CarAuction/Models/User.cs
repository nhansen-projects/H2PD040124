namespace CarAuction.Models;

public class User
{
    private int _id;
    private string _name;
    private string _email;
    private string _password;
    
    public User(int id, string name, string email, string password)
    {
        this._id = id;
        this._name = name;
        this._email = email;
        this._password = password;
    }
}