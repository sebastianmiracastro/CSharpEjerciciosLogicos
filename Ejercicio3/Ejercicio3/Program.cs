using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Suma De N Numeros Y Su Media Aritmetica");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
            double CAN, K;
            int NUM;
            int SUM = 0;
            string linea;
            Console.Write("Limite de Valores: "); linea = Console.ReadLine();
            CAN = byte.Parse(linea);
            for (K = 1; K <= CAN; K++)
            {
                Console.Write("Digite Los Numeros: "); linea = Console.ReadLine();
                NUM = Int32.Parse(linea);
                SUM += NUM;
            }
            Console.WriteLine("La Suma Total Es : " + SUM);
            Console.WriteLine("Media Aritmetica: " + SUM / CAN);
            Console.Write(""); Console.ReadLine();
        }
    }
}
