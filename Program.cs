using System.IO.Pipes;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

        
        Console.WriteLine("Bis zu welcher Zahl soll aufsummiert werden?");
        int untilNumber = Convert.ToInt32(Console.ReadLine());
        
        int ergebnis= 0;
        for(int i=0; i<=untilNumber; i++)
        {
            ergebnis+=i;
            Console.WriteLine($"Added numer{i}, current result {ergebnis}");
        }
       




        }
    }
}