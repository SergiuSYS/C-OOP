public class Person
{
    public string Name{get;}
    Adress Adresa{get;}
    public Person(string name, Adress adress)
    {
        Name = name;
        Adresa = adress;
    }
    public Person DeepCoppy()
    {
        return new Person(this.Name,this.Adresa.DeepCopy());   
    }
}