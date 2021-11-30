using System;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int numRand = rnd.Next(1, 6);
            int chance = 5;


            for (int i = 1; i <= chance; i++)
            {

                Console.Write("INGRESA UN NUMERO DEL 1 AL 10: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num == numRand)
                {
                    Console.WriteLine("¡¡¡Felicidades!!!");
                    break;
                }
                else
                {
                    Console.WriteLine("¡¡¡Incorrecto!!!");
                }

                if (chance == i)
                {
                    Console.WriteLine("Se Acabaron Los intentos");
                }
            }


        }
    }
}