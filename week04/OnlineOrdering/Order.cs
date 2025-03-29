class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    private decimal _shippingCost;

    public Order(Customer customer)
    {
        _customer = customer;
        _shippingCost = _customer.IsInUSA() ? 5m : 35m;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.GetTotalCost();
        }

        totalCost += _shippingCost;

        return totalCost;
    }

    public string GetPackingLabel()
    {
        string label = "";

        foreach (Product product in _products)
        {
            label += product.GetProductInfo() + "\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return _customer.GetCustomerInfo();
    }
}