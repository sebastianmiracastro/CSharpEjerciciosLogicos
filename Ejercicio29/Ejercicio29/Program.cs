using System;

namespace Ejercicio29
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            double km = 0.0;
            double millas = 0.0;
            string dato = "";

            Console.WriteLine("1- Millas a Km, 2. Km a Millas");
            dato = Console.ReadLine();
            opcion = Convert.ToInt32(dato);

            if (opcion == 1)
            {
                Console.WriteLine("Ingrese Las Millas");
                dato = Console.ReadLine();
                millas = Convert.ToDouble(dato);

                km = millas * 1.609;

                Console.WriteLine("{0} millas son {1} km", millas, km);
            }
            if (opcion == 2)
            {
                Console.WriteLine("Dame Los Km");
                dato = Console.ReadLine();
                km = Convert.ToDouble(dato);

                millas = km / 1.609;

                Console.WriteLine("{0} Km Son {1} Millas", km, millas);
            }
        }
    }
}
