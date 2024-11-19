Companie c1 = new Companie();
Rezervare r1 = new Rezervare("Ciuciu Sergiu",new DateTime(2024,11,20),30,"A345");
Persoana p1 = new Persoana("Copil Alina", new DateTime(2004, 11, 20));
r1.addPersoana(p1);
c1.Addrezervare(r1);