namespace CarAuction.Models;

public class User
{
    private int _id;
    private string _username;
    private string _postalCode;
    private string _password;

    public User(int id, string username, string postalCode, string password)
    {
        this._id = id;
        this._username = username;
        this._postalCode = postalCode;
        this._password = password;
    }
    public User()
    {
        _id = 0;
        _username = string.Empty;
        _postalCode = string.Empty;
        _password = string.Empty;

    }
    
    public int Id
    {
        get => _id;
        set => _id = value;
    }
    public string Username
    {
        get => _username;
        set => _username = value;
    }
    public string PostalCode
    {
        get => _postalCode;
        set => _postalCode = value;
    }
    public string Password
    {
        get => _password;
        set => _password = value;
    }
}