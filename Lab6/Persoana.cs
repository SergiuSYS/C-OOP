public class Persoana
{
    string numePrenume;
    DateTime dataNastere;
    public Persoana(string numeprenume, DateTime datanastere)
    {
        numePrenume = numeprenume;
        dataNastere = datanastere;
    }
    //aici ne intereseaza numa outputul nu ne cere sa scriem dece ca si la clasa rezervare
    public bool isValid()
    {
        if (ValidareNume() == false || VlaidareDataNasteri() || false)
        { 
            return false; 
        }
        return true;
    }

    // restul de validari mici vor fi private, numa functia principala va fi publica incat sa fie accesata inafara clasei
    private bool ValidareNume()
    {
        if (numePrenume.Length < 30)
        {
            return true;
        }
        return false;
    }
    private bool VlaidareDataNasteri()
    {
        // facem o variabila data temporara
        DateTime temp = DateTime.Now;
        //acum la variabila temp ii scadem un an
        temp.AddYears(-1);
        if (dataNastere >= temp)
        {
            return true;
        }
        return false;
    }
}