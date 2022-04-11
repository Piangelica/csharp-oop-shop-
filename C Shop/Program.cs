// See https://aka.ms/new-console-template for more information

using C_Shop;

Console.WriteLine("Inserisci il codice del prodotto: ");
int codice = int.Parse(Console.ReadLine());
Console.WriteLine("Inserisci il nome del prodotto: ");
string nome = Console.ReadLine();
Console.WriteLine("Inserisci la descrizione del prodotto: ");
string descrizione = Console.ReadLine();
Console.WriteLine("Inserisci il prezzo del prodotto: ");
double prezzo = double.Parse(Console.ReadLine());
Console.WriteLine("Inserisci l'IVA del prodotto: ");
double iva = double.Parse(Console.ReadLine());
Prodotto prodotto1 = new Prodotto(codice);
Prodotto prodotto2 = new Prodotto(codice);



Console.WriteLine();
Console.WriteLine("---Primo Prodotto---");
prodotto1 = new Prodotto(codice);


Console.WriteLine("---Secondo Prodotto---");
prodotto2 = new Prodotto(codice);


Random random = new Random();
int numero = random.Next();
Console.WriteLine(numero);



