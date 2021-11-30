using System;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int K = 0;
            int CAN = 0;
            int RESUL = 0;
            string cadena;
            Program ob = new Program();
            Console.Write("Elija El Tamaño Del Array: ");
            cadena = Console.ReadLine();
            CAN = int.Parse(cadena);
            int[] VEC = new int[CAN + 1];
            Random rnd = new Random();
            for (K = 1; K <= CAN; K++)
            {
                VEC[K] = rnd.Next(1, 100);
                Console.Write(VEC[K] + ", ");
            }
            Console.WriteLine();
            RESUL = ob.VECTORMENOR(VEC, CAN);
            Console.WriteLine();
            Console.WriteLine("El Numero Menor Es: " + RESUL);
            Console.ReadLine();
        }
            private int VECTORMENOR(int[] NUEVO, int N)
            {
                int MEN = 0;
                int I = 0;
                MEN = NUEVO[1];
                for (I = 2; I <= N; I++)
                {
                    if ((NUEVO[I] < MEN))
                        MEN = NUEVO[I];
                }
                return MEN;
            }
    }
}
