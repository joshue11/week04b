using System.Collections.Generic;

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

    public double GetTotalCost()
    {
        double productTotal = 0;

        foreach (Product product in _products)
        {
            productTotal += product.TotalCost();
        }

        double shipping = _customer.LivesInUSA() ? 5 : 35;

        return productTotal + shipping;
    }

    public string GetPackingLabel()
    {
        string label = "PACKING LABEL:\n";

        foreach (Product product in _products)
        {
            label += $"- {product.GetLabel()}\n";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        string label = "SHIPPING LABEL:\n";
        label += $"{_customer.GetName()}\n";
        label += $"{_customer.GetAddress().GetFullAddress()}";

        return label;
    }
}
