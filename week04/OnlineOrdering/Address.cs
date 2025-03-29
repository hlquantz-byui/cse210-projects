class Address
{
    private string _street, _city, _stateProvince, _country;

    public Address(string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public bool IsInUSA()
    {
        return _country == "USA";
    }

    public override string ToString()
    {
        return $"{_street}\n{_city}, {_stateProvince}\n{_country}";
    }
}