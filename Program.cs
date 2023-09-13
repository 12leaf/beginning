namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gebe mir eine erste Zahl!");
            int zahl1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Gebe mir eine zweite Zahl!");
            int zahl2 = Convert.ToInt16(Console.ReadLine());

            int ergebnis = zahl1 + zahl2;

            
            Console.WriteLine($"Das Ergebnis aus {zahl1} und {zahl2} ist {ergebnis}" );
        }
    }
}