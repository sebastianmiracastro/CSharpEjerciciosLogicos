using System;
using System.Diagnostics;
using System.IO;

namespace Ejercicio25
{
    class Program
    {
        static void Main(string[] args)
        {
            //Iniciando El Cronometro
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            //Solicitando el tamaño del vector
            int TamanioVector;
            Console.WriteLine("Hola, Fecha Y Hora De Inicio De La Prueba : " + DateTime.Now);
            Console.WriteLine("Ingrese El Tamaño Del Vector");
            TamanioVector = Convert.ToInt32(Console.ReadLine());
            //Declaro el vector
            int[] Lista = new int[TamanioVector];
            //Generando Numeros Random
            Random rnd = new Random();

            //Añadiendo Los Valores A La Lista
            for (int i = 0; i < Lista.Length; i++)
            {
                Lista[i] = rnd.Next(-1000, 1000);
            }
            //Imprimiendo La Lista(No Ordenada)
            Console.WriteLine("Imprimiendo La Lista");
            //for (int i = 0; i < Lista.Length; i++)
            //{
            //    //Console.WriteLine(Lista[i]);
            //    TextWriter Vector = new StreamWriter(@"D:\HHHH - PSP0\HHHH - PSP0\Pruebas\" + "TotalDe" + TamanioVector + "Datos" + ".txt", true);
            //    Vector.WriteLine(Lista[i]);
            //    Vector.Close();
            //}
            //Implementando Bubble Sort, para acomodar valores de Menor a Mayor.
            int temp = 0;

            for (int i = 0; i < Lista.Length; i++)
            {
                for (int j = 0; j < Lista.Length; j++)
                {
                    if (Lista[i] < Lista[j])
                    {
                        temp = Lista[i];

                        Lista[i] = Lista[j];

                        Lista[j] = temp;
                    }
                }
            }
            for (int i = 0; i < Lista.Length; i++)
            {
                Console.Write("({0}), ", Lista[i]);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            //Finalizando El Cronometrado

            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            Console.WriteLine("El codigo se ha demorado en Ejecutarse Un lapso de " + ts);
        }
    }
}