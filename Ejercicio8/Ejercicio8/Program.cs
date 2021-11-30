using System;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM1 = 0;
            int NUM2 = 0;
            string RESUL;
            string cadena;
            Program ob = new Program();
            Console.Write("Numero A Averiguar Si Es Multiplo De Otro: ");
            cadena = Console.ReadLine();
            NUM1 = int.Parse(cadena);
            Console.Write("Multiplo: ");
            cadena = Console.ReadLine();
            NUM2 = int.Parse(cadena);
            RESUL = ob.MULTIPLO(NUM1, NUM2);
            Console.WriteLine();
            Console.WriteLine("{0} {1} DE {2}", NUM1, RESUL, NUM2);
            Console.ReadLine();
        }
        private string MULTIPLO(int N1, int N2)
        {
            string R;
            int num;
            num = N1 % N2;
            if (num == 0)
            {
                R = "Es Múltiplo";
            }
            else
            {
                R = "No Es Múltiplo";
            }
            return R;
        }
    }
}