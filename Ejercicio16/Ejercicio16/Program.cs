using System;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            int CAN, K;
            int MAY, MEN, NUM;
            string linea;
            Console.Write("Limite: "); linea = Console.ReadLine();
            CAN = byte.Parse(linea);
            Console.Write("Digite Un Numero: "); linea = Console.ReadLine();
            MAY = int.Parse(linea);
            MEN = MAY;
            for (K = 2; K <= CAN; K++)
            {
                Console.Write("Digite Los Numeros: "); linea = Console.ReadLine();
                NUM = int.Parse(linea);
                if (NUM > MAY) MAY = NUM;
                if (NUM < MEN) MEN = NUM;
            }
            Console.WriteLine("EL MAYOR ES : " + MAY);
            Console.WriteLine("EL MENOR ES : " + MEN);
            Console.WriteLine("DIFERENCIA ES : " + (MAY - MEN));
            Console.ReadLine();
        }
    }
}
