using System.Diagnostics.SymbolStore;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public int CalculateToalCost()
    {
        int total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }
        if (_customer.GetInUS() == true)
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }
    public string GetPackingLabel()
    {
        string label = "";
        for (int i = 0; i < _products.Count(); i++)
        {
            Product product = _products[i];
            if (i == 0)
            {
                label = label + $"{product.GetName()}, {product.GetID()}";
            }
            else
            {
                label = label + $"\n{product.GetName()}, {product.GetID()}";
            }
        }
        return label;
    }
    public string GetShippingLabel()
    {
        return _customer.GetAddress();
    }
}