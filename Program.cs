using System.IO.Pipes;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

       Console.WriteLine("Gib eine Zahl ein!");
       int zahl = Convert.ToInt32(Console.ReadLine());
    
        int ergebnis=1;
         for(int zaehlvariable=1;zaehlvariable<=zahl;zaehlvariable++)
        {
        ergebnis = ergebnis * zaehlvariable;
        Console.WriteLine($"{zaehlvariable}");

        }
    



        }
    }
}