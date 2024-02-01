namespace hw1;


public class Laptop : Computer
{
    protected int _processor;
    public Laptop(string name, int price,int battery,int processor): base(name,price,battery)
    {
        _processor=processor;
    }
    public void Info()
    {
        Print();
    }
    public void GetInfo()
    {
        Console.WriteLine($"{_name} {_price} {_battery} {_processor}");
    }
}
