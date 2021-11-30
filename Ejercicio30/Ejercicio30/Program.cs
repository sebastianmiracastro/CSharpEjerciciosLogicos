using System;

namespace Ejercicio30
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Valores = new int[11];
            int numero = 0;
            string dato = "";
            int n = 0;
            int mayor = 0;

            for (n = 0; n < 10; n++)
            {
                Console.WriteLine("Ingresa un numero entre 0 y 10");
                dato = Console.ReadLine();
                numero = Convert.ToInt32(dato);

                Valores[numero]++;
            }
            for(n = 0; n < 11; n++)
            {
                Console.WriteLine("El numero {0} aparecio {1} veces", n, Valores[n]);
            }
            for (n = 0; n < 11; n++)
            {
                if (Valores[n] > mayor)
                    mayor = n;
            }
            Console.WriteLine("El numero que se repitio mas veces es {0}", mayor);
        }
    }
}
