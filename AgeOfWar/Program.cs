// See https://aka.ms/new-console-template for more information
using AgeOfWar.Personaggio;

Console.WriteLine("Hello, World!");

Cavaliere  cav1 =new Cavaliere(1000);
Cavaliere[] squadraRossa = new Cavaliere[100];
for (int i = 0; i < 100; i++)
{
    squadraRossa[i]= new Cavaliere(1000);
    squadraRossa[i].Squadra = "squadra rossa";
}







