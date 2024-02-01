namespace hw2;

public class GruzAvto : Avto
{
     public GruzAvto(string name,string model,string color,int engine)
    : base(name,model,color,engine)
    {}
    public void Info()
    {
        GetInfo();
    }
    public void GetInfo()
    {
        Console.WriteLine($"{_name} {_model} {_color} {_engine}");
    }
}
