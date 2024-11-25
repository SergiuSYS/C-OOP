public class Adress
{
    public string City{get;}
    public string Street{get;}
    public int Number{get;}
    public Adress(string city, string street, int number)
    {
        City = city;
        Street = street;
        Number = number;
    }
    public Adress DeepCopy()
    {
        return new Adress(this.City,this.Street,this.Number);
    }
}