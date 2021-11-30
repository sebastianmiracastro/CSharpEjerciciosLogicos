using System;

namespace Ejercicio28
{
    class Program
    {
        static void Main(string[] args)
        {
            int Negative = 0;
            int Positive = 2;
            string Txt = "S = ";
            Console.WriteLine("Digite Un Numero Para El Limite del contador:");
            int Num = Convert.ToInt32(Console.ReadLine());

            for (int counter = 1; counter <= Num; counter++)
            {
                if (Positive < Negative)
                {
                    Txt = Txt + " + " + counter;
                    Positive = Positive + 1;
                }
                else
                {
                    Txt = Txt + " - " + counter;
                    Positive = 0;
                    Negative += 1;

                    counter = counter + 1;
                }
            }

            Console.WriteLine(Txt);
        }
    }
}
