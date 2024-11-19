using System.Net;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Rezervare 
{
    private string numePrenume;
    private DateTime dataRezervare;
    private int Durata;
    private string codIdentificare;
    private List<Persoana> Persoane = new List<Persoana>();
    
    public Rezervare(string numeprenume, DateTime datarezervare, int durata, string codidentificare)
    {
        numePrenume = numeprenume;
        dataRezervare = datarezervare;
        Durata = durata;
        codIdentificare = codidentificare;
    }
    //functie de adaugat persoane
    public void addPersoana(Persoana persoana)
    {
        //doar daca este valid se va aduga
        if (persoana.isValid())
        {
            Persoane.Add(persoana);
        }
    }
    //verificam fiecare validare
    public bool Isvalid()
    {
        //creem o variablia bool care este true
        //pentru fiecare validare esuata schimbam variabila in false 
        bool isvalid = true;
        if (!ValidareNume()) 
        {
            Console.WriteLine("Numele trebuie să aiba cel puțin 30 de caractere.");
            isvalid= false;
        }
        if (!ValidareData()) 
        { 
            Console.WriteLine("Data rezervarii trebuie să fie în viitor.");
            isvalid = false;
        }
        if (!ValidareDurata())
        { 
            Console.WriteLine("Durata trebuie sa fie între 1 ai 60 de minute.");
            isvalid = false;

        }
        if (!ValidareCod())
        { 
            Console.WriteLine("Codul de identificare este invalid (trebuie să fie de forma 'A###').");
            isvalid = false;
        }
        if (!ValidareLista()) 
        { 
            Console.WriteLine("Lista de persoane nu poate fi goala.");
            isvalid = false;
        }
        return isvalid;
    }

    // toate validarile
    //le facem private incat nu il intereseaza pe utilizator daca fiecare validare este adevarata sau nu 
    // numa validarea finala va fi publica incat sa fie accesata inafara clasei 
    private bool ValidareNume()
    {
        if(numePrenume.Length < 30)
        {
            return true;
        }
        return false;
    }
    private bool ValidareData()
    {
        //DateTime.Now returneaza data de astazi 
        if (dataRezervare >= DateTime.Now)
        {
            return true;
        }
        return false;
    }
    private bool ValidareDurata()
    {
        if(Durata > 1 && Durata< 60)
        {
            return true;
        }
        return false;
    }
    private bool ValidareCod()
    {
        if(codIdentificare.Length > 4)
        {
            return false;
        }
        if (codIdentificare[0] != 'A')
        {
            return false;
        }
        for(int i = 1; i < 4; i++)
        {
            if (!(codIdentificare[i] > '0' && codIdentificare[i] < '9'))
            {
                return false;
            }
        }
        return true;
    }
    private bool ValidareLista()
    {
        if(Persoane.Count == 0)
        {
            return false;
        }
        return true;
    }
}