
//clasa din care se v-a face mostenirea 
public abstract class Colet 
{
    //declararea variabilelor standard pentru fiecare colet
    //sunt facute protected incat sa nu poata fi accesate de utilizator in Programul main dar sa fie accesate in alte clase
    protected string Nume { get; set; }
    protected int Greutate { get; set; }
    protected int TimpLivrare;
    protected int CostPerKg;
    public Colet(string nume, int greutate)
    {
        Nume = nume;
        Greutate = greutate;
    }
    // fecare tip de colet trebuie sa aibe o functie de livrare o facem abstract incat obliga utilizatorul sa creeze una
    public abstract void Livrare();
    //functie de calculare a costului total
    protected int CalculareCostTotal()
    {
        return TimpLivrare * CostPerKg;
    }
    public override string ToString() => $"{Nume} | {Greutate} KG | {TimpLivrare} zile | {CalculareCostTotal()} EUR";
}

public class PachetBaza:Colet
{
    private int CostTotal;
    public PachetBaza(string nume, int greutate) : base(nume,greutate)
    {
        TimpLivrare = 5;
        CostPerKg = 5;
        if (Greutate > 10)
        {
            TimpLivrare += 1;
        }
    }
    public override void Livrare()
    {
        CostTotal = CalculareCostTotal();
        Console.WriteLine($"coletul: {Nume} v-a fi livrat in {TimpLivrare} zile, costul livrarii este {CostTotal}");
    }
}

public class PachetAvansat : Colet
{
    private int CostTotal;
    public PachetAvansat(string nume, int greutate) : base(nume, greutate)
    {
        TimpLivrare = 2;
        CostPerKg = 6;
    }
    public override void Livrare()
    {
        CostTotal = CalculareCostTotal()+2;
        Console.WriteLine($"coletul: {Nume} v-a fi livrat in {TimpLivrare} zile, costul livrarii este {CostTotal}");
    }
}

public class PachetPesteNoapte : Colet
{
    private int CostTotal;
    public PachetPesteNoapte(string nume, int greutate) : base(nume, greutate)
    {
        TimpLivrare = 1;
        CostPerKg = 10;
    }
    public override void Livrare()
    {
        CostTotal = CalculareCostTotal();
        Console.WriteLine($"coletul: {Nume} v-a fi livrat in {TimpLivrare} zile, costul livrarii este {CostTotal}");
    }
}
