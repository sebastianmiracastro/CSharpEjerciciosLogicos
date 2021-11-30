using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte NUM, I, Limit;
            int RESUL;
            string linea;
            string Limite;
            Console.WriteLine("Ejercicio 1: Tabla De Multiplicar");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.Write("Digite Un Número: "); linea = Console.ReadLine();
            NUM = byte.Parse(linea);
            Console.Write("Pongale Un Limite A La Tabla: "); Limite = Console.ReadLine();
            Limit = byte.Parse(Limite);
            for (I = 1; I <= Limit; I++)
            {
                RESUL = NUM * I;
                Console.WriteLine("{0} * {1} = {2}", NUM, I, RESUL);
            }
            Console.Write(""); Console.ReadLine();
        }
    }
}
