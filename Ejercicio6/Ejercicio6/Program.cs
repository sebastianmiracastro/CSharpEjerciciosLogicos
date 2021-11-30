using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM1, NUM2, RESUL;
            string linea;
            Console.WriteLine("Ejercicio 6: Operaciones Basicas Matematicas.");
            Console.Write("Ingrese Un Numero: ");
            linea = Console.ReadLine();
            NUM1 = int.Parse(linea);
            Console.Write("Ingrese Un Numero: ");
            linea = Console.ReadLine();
            NUM2 = int.Parse(linea);
            Console.WriteLine();
            RESUL = NUM1 + NUM2;
            Console.WriteLine("La Suma Es: {0}: ", RESUL);
            RESUL = NUM1 - NUM2;
            Console.WriteLine("La Resta Es: {0} - {1} = {2} ", NUM1, NUM2, RESUL);
            RESUL = NUM1 * NUM2;
            Console.WriteLine("La Multiplicación Es: " + RESUL);
            RESUL = NUM1 / NUM2;
            Console.WriteLine("La División Es: " + RESUL);
            RESUL = NUM1 % NUM2;
            Console.WriteLine("El Residuo Es: " + RESUL);
            Console.Write(""); Console.ReadLine();
        }
    }
}
