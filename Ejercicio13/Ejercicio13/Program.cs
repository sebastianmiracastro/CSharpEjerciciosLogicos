using System;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM1, NUM2, NUM3;
            string linea;
            Console.Write("Primer Numero: "); linea = Console.ReadLine();
            NUM1 = int.Parse(linea);
            Console.Write("Segundo Numero: "); linea = Console.ReadLine();
            NUM2 = int.Parse(linea);
            Console.Write("Tercer Numero: "); linea = Console.ReadLine();
            NUM3 = int.Parse(linea);
            Console.WriteLine();
            Console.Write("El Intermedio es: ");
            if ((NUM1 > NUM2))
            {
                if ((NUM1 < NUM3))
                {
                    Console.WriteLine(NUM1);
                }
                else
                {
                    if ((NUM2 < NUM3))
                    {
                        Console.WriteLine(NUM3);
                    }
                    else
                    {
                        Console.WriteLine(NUM2);
                    }
                }
            }
            else
            {
                if ((NUM2 < NUM3))
                {
                    Console.WriteLine(NUM2);
                }
                else
                {
                    if ((NUM1 < NUM3))
                    {
                        Console.WriteLine(NUM3);
                    }
                    else
                    {
                        Console.WriteLine(NUM1);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}