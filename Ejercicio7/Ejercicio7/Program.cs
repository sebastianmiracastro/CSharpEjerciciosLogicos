using System;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            string NOM;
            Program ob = new Program();
            Console.Write("Frase: ");
            NOM = Console.ReadLine();
            Console.Write("Resultado: " + ob.INVERTIR(NOM));
            Console.WriteLine();
            Console.Write("");
            Console.ReadLine();
        }
        public string INVERTIR(string FRASE)
        {
            string AUX;
            string cadena;
            Program ob = new Program();
            int POS = FRASE.Length;
            Console.WriteLine(POS);
            AUX = "";
            while (POS >= 1)
            {
                cadena = ob.Mid(FRASE, POS - 1);
                AUX = AUX + cadena;
                POS--;
            }
            return AUX;
        }
        public string Mid(string param, int startIndex)
        {
            return param.Substring(startIndex, 1);
        }
    }
}
