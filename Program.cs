namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gib eine erste Zahl an!");
            int zahl1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Gib eine zweite Zahl an!");
            int zahl2 = Convert.ToInt16(Console.ReadLine());

            int ergebnis = zahl1 - zahl2;

            Console.WriteLine($"Das Ergebnis aus {zahl1} und {zahl2} ist {ergebnis}");

        }
    }
}