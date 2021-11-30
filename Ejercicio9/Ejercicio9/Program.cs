using System;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que Dia De La Semana Es.");
            int NUM = 0;
            string RESUL = null
           ;
            string cadena;
            Program ob = new Program();
            Console.Write("Digite Un Numero : ");
            cadena = Console.ReadLine();
            NUM = int.Parse(cadena);
            RESUL = ob.DIASEMANA(NUM);
            Console.WriteLine();
            Console.WriteLine("Resultado: " + RESUL);
            Console.ReadLine();

        }
        private string DIASEMANA(int DIA)

        {
            string R = null
           ;
            switch (DIA)

            {
                case 1:
                    R = "Domingo"
                   ;
                    break
                    ;
                case 2:
                    R = "Lunes"
                   ;
                    break
                   ;
                case 3:
                    R = "Martes"
                   ;
                    break
                    ;
                case 4:
                    R = "Miercoles"
                   ;
                    break
                    ;
                case 5:
                    R = "Jueves"
                   ;
                    break
                    ;
                case 6:
                    R = "Viernes"
                   ;
                    break
                    ;
                case 7:
                    R = "Sábado"
                   ;
                    break
                    ;
                default
           :
                    R = "Fuera De Rango"
                   ;
                    break
                   ;

            }
            return (R);

        }

    }
}
        }
    }
}
