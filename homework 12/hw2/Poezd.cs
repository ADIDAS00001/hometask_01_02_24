namespace hw2;

public class Poezd  : Transport
{
     public Poezd(string name,string model,string color,int engine)
    : base(name,model,color,engine)
    {}
    public void Info()
    {
        Print();
    }
    public void GetInfo()
    {
        Console.WriteLine($"{_name} {_model} {_color} {_engine}");
    }
}
