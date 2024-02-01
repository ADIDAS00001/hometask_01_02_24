namespace hw1;

public class SmartPhone : Computer
{
    protected string _camera;
     public SmartPhone(string name, int price,int battery,string cmaera): base(name,price,battery)
    {
        _camera=cmaera;
    }
     public void Info()
    {
        Print();
    }
    public void GetInfo()
    {
        Console.WriteLine($"{_name} {_price} {_battery} {_camera}");
    }
}
