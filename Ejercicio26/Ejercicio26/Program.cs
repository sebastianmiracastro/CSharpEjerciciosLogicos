using System;

namespace Ejercicio26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" + ,  -   =  1 + 2 - 3 + 4 -5 ");

            int counter = 1; //Si quiere que este se ejecute solo un mas y otro un menor, comienzelo en 0
            int Negative = 1; //Si quiere que este se ejecute solo un mas y otro un menor, comienzelo en 0
            int Positive = 1; // Si quiere que este se aumente de a 1 Ponga este en 0 Y el contador tambien en 0
            string Txt = "S = ";
            Console.WriteLine("Digite Un Numero Para El Limite del contador:");
            int Num = Convert.ToInt32(Console.ReadLine());

            while (counter <= Num)
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
