using System.Runtime.CompilerServices;

public class Order
{
    private Customer _customer;
    public List<Product> _productList;

    public Order(Customer customer)
    {
        _customer = customer;
        _productList = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _productList.Add(product);
    }

    public double TotalPrice()
    {
        double totalPrice = 0;
        foreach (var product in _productList)
        {
            totalPrice += product.TotalCost();
        }
        totalPrice += _customer.IsInUSA() ? 5 : 35;
        return totalPrice;
    }

    public string PackingLabel()
    {
        string label = "Packing Label:\n";
        foreach(var product in _productList)
        {
            label += $"{product.GetName()}, ID:{product.GetProductId()}\n";
        }
        return label;
    }

    public string ShippingLabel()
    {
        return $"Shipping label:\n{_customer.GetName()}\n{_customer.GetAddress()}";
    }
}