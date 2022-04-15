// See https://aka.ms/new-console-template for more information

using Geometria;

Console.WriteLine("Hello, Worl!");

Console.WriteLine("\nInserisci la base del rettangolo");
int inputBaseUtente = int.Parse(Console.ReadLine());

Console.WriteLine("Inserisci l'altezza del rettangolo");
int inputAltezzaUtente = int.Parse(Console.ReadLine());

rettangolo rettangolo1 = new rettangolo(inputBaseUtente, inputAltezzaUtente);

//----RETTANGOLO 1-------

rettangolo1.stampaRettangolo();

//----RETTANGOLO 2-----

Console.WriteLine("\nInserisci la base del rettangolo");
inputBaseUtente = int.Parse(Console.ReadLine());

Console.WriteLine("Inserisci l'altezza del rettangolo");
inputAltezzaUtente = int.Parse(Console.ReadLine());

rettangolo rettangolo2 = new rettangolo(inputBaseUtente, inputAltezzaUtente);

rettangolo2.stampaRettangolo();


