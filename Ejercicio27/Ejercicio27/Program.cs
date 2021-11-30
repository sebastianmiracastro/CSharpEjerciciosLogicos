using System;

namespace Ejercicio27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pongale Un Limite Al Contador: ");
            int Num = Convert.ToInt32(Console.ReadLine());
            int Up = 1;
            string Txt = "S = ";

            for (int Down = 3; Down <= Num; Down++)
            {
                if (Up < Down)
                {
                    Txt = Txt + Up + " / " + Down + " + ";
                    Up++;
                }
            }
            Console.WriteLine(Txt);
        }
    }
}
