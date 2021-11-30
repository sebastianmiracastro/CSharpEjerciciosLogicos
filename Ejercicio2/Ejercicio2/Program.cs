using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 2: SUMA DE N NÚMEROS PARES E IMPARES.");
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            byte NUM;
            int Pares = 0;
            int Impares = 0;
            string Number;
            Console.Write("Número Limite: "); Number = Console.ReadLine();
            NUM = (byte)Int32.Parse(Number);
            for (int i = 1; i <= NUM; i += 2)
            {
                Pares = Pares + i;
            }
            for (int j = 2; j <= NUM; j += 2)
            {
                Impares = Impares + j;
            }
            Console.WriteLine("Total De Numeros Pares: " + Pares);
            Console.WriteLine("Total De Numeros Impares: " + Impares);
            Console.Write(""); Console.ReadLine();

        }
    }
}
