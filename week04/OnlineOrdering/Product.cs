public class Product
{
    private string _name;
    private int _productId;
    private float _price;
    private int _quantity;

    public Product(string name, int productId, float price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public string GetName() => _name;
    public int GetProductId() => _productId;
    public float GetPrice() => _price;
    public int GetQuantity() => _quantity;

    public float GetTotalCost()
    {
        return _price * _quantity;
    }
}