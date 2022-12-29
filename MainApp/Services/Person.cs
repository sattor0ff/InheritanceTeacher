namespace MainApp.Services;

public class Person : Object
{
    protected string _name;
    protected string _address;

    public Person(string name, string address)
    {
        _name = name;
        _address = address;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetAddress()
    {
        return _address;
    }
    public void SetAddress(string address)
    {
        _address = address;
    }
    public override string ToString()
    {
        return $"{_name} ({_address})";
    }
}