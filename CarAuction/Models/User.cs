namespace CarAuction.Models;

public class User
{
    private int _id;
    private string _name;
    private string _email;
    private string _username;
    private string _password;
    
    public User(int id, string name, string email, string username, string password)
    {
        this._id = id;
        this._name = name;
        this._email = email;
        this._username = username;
        this._password = password;
    }

    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Email
    {
        get { return _email; }
        set { _email = value; }
    }

    public string Username
    {
        get { return _username; }
        set { _username = value; }
    }

    public string Password
    {
        get { return _password; }
        set { _password = value; }
    }


}