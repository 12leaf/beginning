using System.IO.Pipes;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

        Console.WriteLine("Gib einen Text mit einem Semikolon ein!");
        string text = Console.ReadLine();
        string myText = text.Replace("U","g");
        string myText2 = myText.Replace("G","g");

        Console.WriteLine(myText2);
        }
    }
}