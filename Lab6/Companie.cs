public class Companie()
{
    private List<Rezervare> Rezervari = new List<Rezervare>();
    public void Addrezervare(Rezervare rezervare)
    {
        if (rezervare.Isvalid())
        {
            Rezervari.Add(rezervare); 
        }
    }
}