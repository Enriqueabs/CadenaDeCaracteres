using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            //pregunta el nombre de usuario//
            Console.WriteLine("Como te llamas?: ");
            nombre = Console.ReadLine();
            Console.WriteLine( "hola " +  nombre 
                + " Quieres ver el menu ");
            Console.ReadKey();
        }
    }
}
