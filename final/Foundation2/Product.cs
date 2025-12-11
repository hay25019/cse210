public class Product
{
    private string _name;
    private string _productID;
    private int _pricePerUnit;
    private int _quantity;

    public Product(string name, string productID, int price, int quantity)
    {
        _name = name;
        _productID = productID;
        _pricePerUnit = price;
        _quantity = quantity;
    }
    public int GetTotalCost()
    {
        return _pricePerUnit * _quantity;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetID()
    {
        return _productID;
    }
}