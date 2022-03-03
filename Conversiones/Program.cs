using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversiones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            int num1  = 5, num2 , resultado;
            //preguntando al usuario el numero//
            Console.Write("dame un numero para sumarlo: " );
            //asigna variable de tipo string
            cadena = Console.ReadLine();
            num2 = Convert.ToInt32(cadena);
            //realiza la suma//
            resultado = num1 + num2;
            Console.WriteLine("el resultado es: " + resultado);
            Console.ReadKey();
        }
    }
}
