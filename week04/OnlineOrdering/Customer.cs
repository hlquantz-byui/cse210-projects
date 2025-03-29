class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, string street, string city, string stateProvince, string country)
    {
        _name = name;
        _address = new Address(street, city, stateProvince, country);
    }

    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

    public string GetCustomerInfo()
    {
        return $"{_name}\n{_address.ToString()}";
    }
}