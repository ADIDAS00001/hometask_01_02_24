namespace hw2;

public class Transport
{
    protected string _name;
    protected string _model;
    protected string _color;
    protected double _engine;
    public Transport(string name,string model,string color,double engine)
    {
        _name=name;
        _model=model;
        _color=color;
        _engine=engine;
    }
    public void Print()
    {
    Console.WriteLine($"{_name} {_model} {_color} {_engine} ");
    }
}
