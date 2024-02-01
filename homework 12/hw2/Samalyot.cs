namespace hw2;

public class Samalyot : Transport
{
    public Samalyot(string name,string model,string color,int engine)
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
