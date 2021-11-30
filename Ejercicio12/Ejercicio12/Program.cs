using System;

namespace Ejercicio12
{
    class Program
    {
        public void Principal()
        {
            int TamanioVector;
            int Opcion = 0;
            string BuscarValor = "";
            string ValorEditado = "";

            Console.WriteLine("¿De Que Tamaño Solicita el Vector?");
            TamanioVector = Convert.ToInt32(Console.ReadLine());

            string[] Vector = new string[TamanioVector];
            do
            {
                MostrarOpciones();
                switch (Opcion)
                {
                    case 1:
                        AñadirDatos();
                        break;

                    case 2:
                        EliminarDatos();
                        break;

                    case 3:
                        EditarDatos();
                        break;

                    case 4:
                        BuscarDatos();
                        break;

                    case 5:
                        MostrarDatos();
                        break;

                    case 6:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Esta Opcion No Existe");
                        break;
                }
            } while (Opcion != 0);
        }
        public void MostrarOpciones()
        {
            Console.WriteLine("----------------Menu----------------");
            Console.WriteLine("1- Añadir un nuevo valor    ");
            Console.WriteLine("2- Eliminar valor existente   ");
            Console.WriteLine("3- Editar datos existentes    ");
            Console.WriteLine("4- Buscar un valor   ");
            Console.WriteLine("5- Mostrar todos los datos añadidos   ");
            Console.WriteLine("6- Cerrar programa");
            Opcion = int.Parse(Console.ReadLine());
        }
        public void AñadirDatos()
        {
            Console.Clear();
            for (int i = 0; i < Vector.Length; i++)
            {
                Console.WriteLine("Añadir nuevo valor al vector: ");
                Vector[i] = Console.ReadLine();
            }
        }
        public void EliminarDatos()
        {
            Console.Clear();
            Console.WriteLine("Eliminar Valor");
            BuscarValor = Console.ReadLine();
            for (int i = 0; i < Vector.Length; i++)
            {
                if (Vector[i] == BuscarValor)
                {
                    Vector[i] = "";
                    Console.WriteLine("Datos Borrados");
                }
            }
        }
        public void EditarDatos()
        {
            Console.Clear();
            Console.WriteLine("Buscar el valor");
            BuscarValor = Console.ReadLine();
            Console.WriteLine("Escriba la edicion del valor");
            ValorEditado = Console.ReadLine();
            for (int i = 0; i < Vector.Length; i++)
            {
                if (Vector[i] == BuscarValor)
                {
                    Vector[i] = ValorEditado;
                    Console.WriteLine("Datos actualizados");
                }
            }
        }
        public void BuscarDatos()
        {
            Console.Clear();
            Console.WriteLine("Esciba el valor que quiere buscar: ");
            BuscarValor = Console.ReadLine();
            foreach (string value in Vector)
            {
                if (value == BuscarValor)
                {
                    Console.WriteLine("Existe el valor puesto " + value);
                }
            }
        }
        public void MostrarDatos()
        {
            Console.Clear();
            foreach (string value in Vector)
            {
                Console.WriteLine(value);
            }
        }
    }
}