public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public bool GetInUS()
    {
        return _address.InUS();
    }
    public string GetName()
    {
        return _name;
    }
    public string GetAddress()
    {
        return $"{_name.ToUpper()}\n{_address.FullAddress()}";
    }
}