// See https://aka.ms/new-console-template for more information
//
using Internship2022.Alimente;

//int age = 22;
int scor = 0;
bool input = false;

Console.WriteLine("Wellness");

//const int age = 18;
//age = 20;

Console.WriteLine("Cata apa bei pe zi?");
Console.WriteLine("1: 1 litri");
Console.WriteLine("2: 2 litri");
Console.WriteLine("3: 3-5 litri");

var cantApaNevalidat = Console.ReadLine();

int cantApaValidat = 0;
//cantApaValidat = 

while (!(int.TryParse(cantApaNevalidat, out cantApaValidat))) 
{
    Console.WriteLine("Introduceti un numar intreg");
    cantApaNevalidat = Console.ReadLine();
}

while(Int32.Parse(cantApaNevalidat) < 0 || Int32.Parse(cantApaNevalidat) > 10) {
    Console.WriteLine("Introduceti un numar intreg pozitiv intre 1 si 10");
    cantApaNevalidat = Console.ReadLine();
}

cantApaValidat = Int32.Parse(cantApaNevalidat);

scor += cantApaValidat;
//var water = Console.ReadLine();

if(scor < 1)
{
    Console.WriteLine("Mai bea apa");
}
else
{
    Console.WriteLine("Esti bine");
}

var alimente = new Alimente();

Console.WriteLine("Hello, World!");

Console.Write("Press key");
Console.ReadKey();
