using System;

namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad;
            double contador = 0.0;
            Console.WriteLine("Ingrese la cantidad de productos");
            cantidad = int.Parse(Console.ReadLine());
            string[] producto = new string[cantidad];
            double[] precio = new double[cantidad];
            for (int a = 0; a < precio.Length; a++)
            {
                Console.WriteLine("Ingrese el nombre y el precio del {0}° producto", a + 1);
                producto[a] = Console.ReadLine();
                precio[a] = double.Parse(Console.ReadLine());
                contador = contador + precio[a];
            }
            Console.WriteLine("El total es " + contador);
            Console.ReadKey();
        }
    }
}
