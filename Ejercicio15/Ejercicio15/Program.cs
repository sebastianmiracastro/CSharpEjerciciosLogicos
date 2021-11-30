using System;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM, RESUL, T, I;
            string linea;
            Console.Write("Cuantas tablas quiere visualizar?: "); linea = Console.ReadLine();
            NUM = int.Parse(linea);
            for (T = 1; T <= NUM; T++)
            {
                for (I = 10; I >= 1; I--)
                {
                    RESUL = T * I;
                Console.WriteLine("{0} * {1} = {2}", T, I, RESUL);
                }
                Console.ReadLine();
            }
        }
    }
}