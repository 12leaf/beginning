using System.IO.Pipes;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

              Console.WriteLine("Gib einen Text ein!");
                     string text = Console.ReadLine();
char ch = 'a';
int freq = text.Split(ch).Length-1;
              Console.WriteLine(freq);

        }
    }
}