namespace hw2;

public class GruzSamalyot : Samalyot
{
      public GruzSamalyot(string name,string model,string color,int engine)
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
