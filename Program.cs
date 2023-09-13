using System.IO.Pipes;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

        List<int> myNumberList = new List<int>();
        Console.WriteLine("Bis zu welcher Zahl soll aufsummiert werden?");
        int untilNumber = Convert.ToInt32(Console.ReadLine());

        int i=0;
        int ergebnis= 0;
        int zahl=0;

        while(i<untilNumber)
        {
            zahl = i+1;
            ergebnis = ergebnis + zahl;
            Console.WriteLine($"Added numer{i}, current result {ergebnis}");
            i++;
        }
       




        }
    }
}