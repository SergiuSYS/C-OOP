using System.Drawing;

public class Car
{
    public string plateNumber {get;}
    public int Color {get;}
    public int Year{get;}
    //obiecte 
    Person owner{get;}
    Engine Engine{get;}
    public Car(string platenumber, int color,int year, Person person, Engine engine)
    {
        plateNumber = platenumber;
        Color = color;
        Year = year;
        owner = person;
        Engine = engine;
    }
    public override bool Equals(object obj)
    {
        // verificam daca obiectul este null sau daca obiectele sunt de tiputi diferite
        if(obj == null || GetType() != obj.GetType())
            return false;
        
        //castarea obiectului obj la tipul de Car
        Car car = (Car)obj;
        return(plateNumber == car.plateNumber);
    }
    public Car DeepCopy()
    {
        return new Car(this.plateNumber,this.Color,this.Year,this.owner.DeepCoppy(),this.Engine.DeepCopy());
    }
}
