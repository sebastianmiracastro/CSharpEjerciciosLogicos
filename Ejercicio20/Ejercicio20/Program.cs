using System;

namespace Ejercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "";
            Console.WriteLine("Ingrese el nombre del alumno");
            nombre = Console.ReadLine();
            int cantidad;
            Console.WriteLine("Ingrese la cantidad de notas de practicas ; ");
            cantidad = int.Parse(Console.ReadLine());
            int[] notas = new int[cantidad];
            for (int a = 0; a < notas.Length; a++)
            {
                Console.WriteLine("Ingrese la {0}° nota", a + 1);
                notas[a] = int.Parse(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}