namespace cw1;

public class Phone : Product
{
    public Phone(string name, int price):base(name,price)
    {

    }
    public void Info()
    {
       Print();
    }
      public void GetInfo()
    {
        System.Console.WriteLine($"{_name} {_price}");
    }
}
