using System.IO.Pipes;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

       Console.WriteLine("Nenne eine Zahl!");
       int zahl1 = Convert.ToInt32(Console.ReadLine());

       Console.WriteLine("Nenne eine zweite Zahl!");
       int zahl2 = Convert.ToInt32(Console.ReadLine());

       int ergebnis = zahl1 + zahl2;
       Console.WriteLine($"Das ergebnis aus {zahl1} und {zahl2} ist {ergebnis}");




        }
    }
}