namespace cw1;

public class Car : Product
{
    public Car(string name , int price ):base(name,price)
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
