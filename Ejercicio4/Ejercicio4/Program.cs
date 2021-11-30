using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 4: Serie De Fibonacci.");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            double CAN, K;
            int A, B, C;
            string linea;
            Console.Write("Limite De Numeros: ");  linea = Console.ReadLine();
            CAN = Int32.Parse(linea);
            A = 1; B = 1;
            Console.Write(A + " " + B + " ");
            for (K = 3; K <= CAN; K++)
            {
                C = A + B;
                Console.Write(C + " ")
                A = B;
                B = C;
            }
            Console.WriteLine();
            Console.Write(""); Console.ReadLine();

        }
    }
}
