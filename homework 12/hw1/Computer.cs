namespace hw1;

public class Computer
{
    protected string _name;
    protected int _price;
    protected int _battery;
    public Computer(string name, int price, int _battery)
    {
        _name=name;
        _price=price;
        _battery=_battery;
    }
    public void Print()
    {
    Console.WriteLine($"Name: {_name} Price: {_price} Battery: {_battery} ");
    }
}
