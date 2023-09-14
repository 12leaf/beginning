using System.IO.Pipes;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

       Console.WriteLine("Gib eine Zahl ein!");
       int zahl = Convert.ToInt32(Console.ReadLine());
    

         for(int zaehlvariable=1;zaehlvariable<=zahl;zaehlvariable++)
        {
        if(zaehlvariable%2==0&&zaehlvariable!=0)
        {
        Console.WriteLine($"{zaehlervariable}");
        }
        }




        }
    }
}