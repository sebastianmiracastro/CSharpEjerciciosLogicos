using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 5: Intento De Reloj Digital.");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            Console.SetCursorPosition(15, 2);
            for (byte H = 0; H <= 24; H++)
            {
                for (byte M = 0; M <= 59; M++)
                {
                    for (byte S = 0; S <= 59; S++)
                    {
                        Console.SetCursorPosition(20, 10);
                        Console.Write("{0} : {1} : {2}", H, M, S);
                    }
                }
            }
            Console.SetCursorPosition(25, 15);
            Console.Write(""); Console.ReadLine();
        }
    }
}
