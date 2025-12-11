public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street.ToUpper();
        _city = city.ToUpper();
        _state = state.ToUpper();
        _country = country.ToUpper();
    }
    public bool InUS()
    {
        if (_country == "UNITED STATES")
        {
            return true;
        }
        return false;
    }
    public string FullAddress()
    {
        return $"{_street}\n{_city} {_state}\n{_country}";
    }
}