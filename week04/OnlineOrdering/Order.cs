
class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void PopulateList(Product product)
    {
        _products.Add(product);
    }

    public int ComputeTotalCost()
    {
        if (_customer.IsInUsa())
        {
            int accumulator = 0;
            foreach (var p in _products)
            {
                accumulator += p.GetTotalCost();
            }
            return accumulator + 5;
        }
        else
        {
            int accumulator = 0;
            foreach (var p in _products)
            {
                accumulator += p.GetTotalCost();
            }
            return accumulator + 35;
        }
    }

    public string GetPackingLabel()
    {
        string accumulator = "";
        foreach (var p in _products)
        {
            string name = p.GetName();
            int id = p.GetId();
            accumulator += $"{name}  -  ID:{id}\n";
            // accumulator += $"{p.GetName()}  -  ID:{p.GetId}\n";
        }
        return accumulator;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}  -  {_customer.GetAddress()}\n";
    }
}

