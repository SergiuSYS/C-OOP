int n = 1;
// am folosit polimorfism
List<Colet> Colete = new List<Colet>();

while (n != 0) { 
    Console.WriteLine("=========== MAIN ===========");
    Console.WriteLine("alegeti una din optiuni: ");
    Console.WriteLine(" 1. adaugare colet");
    Console.WriteLine(" 2. afisare lista colete");
    Console.WriteLine(" 0. iesire");
    n = int.Parse(Console.ReadLine());
    switch (n) {
        case 1:
            AddColet();
            break;
        case 2:
            AfisareColete();
            break;
    }
}

void AddColet()
{
    Console.WriteLine("introdu numele coletului: ");
    string nume = Console.ReadLine();
    Console.WriteLine("introdu greutatea coletului: ");
    int Greutate = int.Parse(Console.ReadLine());
    Console.WriteLine("Alege tipul coletului: ");
    Console.WriteLine(" 1. BasicPackage");
    Console.WriteLine(" 2. AdvancedPackage");
    Console.WriteLine(" 3. OvernightPackage");
    int tip = int.Parse(Console.ReadLine());

    Colet colet = null;

    switch (tip)
    {
        case 1:
            colet = new PachetBaza(nume, Greutate);
            break;
        case 2:
            colet = new PachetAvansat(nume, Greutate);
            break;
        case 3:
            colet = new PachetPesteNoapte(nume, Greutate);
            break;
        default:
            Console.WriteLine("Optiune invalida. Nu s-a adaugat niciun colet.");
            return;
    }
    Colete.Add(colet);
    Console.WriteLine($"{colet} a fost adaugat cu succes!");
}
void AfisareColete()
{
    foreach(var c in Colete)
    {
        Console.WriteLine(c);
    }
}