using System;

namespace Ejercicicio21
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cantidad = new int[3];
            int[] examenp = new int[3];
            int[] exameno = new int[3];
            int[] examenf = new int[3];
            int tp1 = 0, tp2 = 0, tp3 = 0;
            for (int c = 0; c < cantidad.Length; c++)
            {
                Console.WriteLine("Introduzca las notas del {0}ª del alumno", c + 1);
                Console.Write("Examen Parcial ==> ");
                examenp[c] = int.Parse(Console.ReadLine());
                Console.Write("Examen Oral ==> ");
                exameno[c] = int.Parse(Console.ReadLine());
                Console.Write("Examen Final ==> ");
                examenf[c] = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                tp1 = (examenp[0] + exameno[0] + examenf[0]) / 3;
                tp2 = (examenp[1] + exameno[1] + examenf[1]) / 3;
                tp3 = (examenp[2] + exameno[2] + examenf[2]) / 3;
            }
            Console.WriteLine("Promedio del primer alumno : " + tp1);
            Console.WriteLine("Promedio del segundo alumno: " + tp2);
            Console.WriteLine("Promedio del tercer alumno: " + tp3);
            if (tp1 > 13 && tp2 > 13 && tp3 > 13)
            {
                Console.WriteLine("APROBADOS");
            }
            else if (tp1 < 13)
            {
                Console.WriteLine("El 1° alumno : DESAPROBADO");
            }
            else if (tp2 < 13)
            {
                Console.WriteLine("El 2° alumno : DESAPROBADO");
            }
            else
            {
                Console.WriteLine("El 3° alumno : DESAPROBADO");
            }
            Console.ReadKey();
        }
    }
}