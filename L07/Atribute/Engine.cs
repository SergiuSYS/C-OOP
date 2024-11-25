public class Engine
{
    public string Fuel{get;}
    public int Power{get;}
    public Engine(string fuel, int power)
    {
        Fuel = fuel;
        Power = power;
    }
    public Engine DeepCopy()
    {
        return new Engine(this.Fuel,this.Power);
    }
}