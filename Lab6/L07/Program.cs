Adress adress1 = new Adress("Timisoara","Ana iaptescu",8);
Person owner1 = new Person("Ciuciu Sergiu",adress1);
Engine engine1 = new Engine("Benzina",250);

Adress adress2 = new Adress("Timisoara","Claea sagului",322);
Person owner2 = new Person("Ion Pop",adress2);
Engine engine2 = new Engine("Motorina",80);


Car ford = new Car("b3435",32432,2020,owner1,engine1);
Car dacia = new Car("b3535",32432,2020,owner2,engine2);
Console.WriteLine(ford.Equals(dacia));
Car ford1 = ford.DeepCopy();
Console.WriteLine(ford.Equals(ford1));


/*
    transformarea dintr un tip de data in altul folosind castare 
float num  = 343.67686f;
num = (int)num;
 */