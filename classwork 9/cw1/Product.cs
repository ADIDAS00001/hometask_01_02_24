namespace cw1;

public class Product : Shop
{
    protected string _name;
    protected int _price;
    public Product(string name, int price)
    {
        _name=name;
        _price=price;
    }
    public void Print()
    {
        System.Console.WriteLine($"{_name} {_price}");
    }
}
