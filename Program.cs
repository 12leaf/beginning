using System.IO.Pipes;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

       Console.WriteLine("Gib eine Zahl ein!");
       int zahl = Convert.ToInt32(Console.ReadLine());

        for(int zaehlvariable=0;zaehlvariable<=zahl;zaehlvariable++)
        {
            Console.WriteLine(zaehlvariable);
        }
      

       




        }
    }
}