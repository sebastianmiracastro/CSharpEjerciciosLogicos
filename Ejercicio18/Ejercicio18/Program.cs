using System;

namespace Ejercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valores = { 4, 3, 7, 10, 1, 5, 7, 8, 9, 15, 53, 12, 34, 54, 56,76,23,3 };

            Array.Sort(valores);

            for (int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine(valores[i]);
            }

            Console.ReadLine();
        }
    }
}