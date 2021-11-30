﻿using System;

namespace Ejercicio24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Serie De Numeros.");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            private int[,] serie;

        public void Cargar()
        {
            serie = new int[10, 10];
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    if (j % 2 == 0)
                    {
                        serie[i, j] = 0;
                    }
                    else
                    {
                        serie[i, j] = 1;
                    }
                }
            }
        }

        public void visualizar()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("\n");
                for (int j = 1; j <= 6; j++)
                {
                    Console.Write(serie[i, j] + " ");
                }
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            PruebaVector pv = new PruebaVector();
            pv.Cargar();
            pv.visualizar();
        }
    }
}
