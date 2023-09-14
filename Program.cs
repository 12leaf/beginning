using System.IO.Pipes;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

        Console.WriteLine("Gib einen Text mit Semikolon ein!");
        string text = Console.ReadLine();
        
        string[] text2 = text.Split(";");

        foreach(string abc in text2)
        {
            Console.WriteLine(abc);
        }

        Console.WriteLine(text2);
        }
    }
}