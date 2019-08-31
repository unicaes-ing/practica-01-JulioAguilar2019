using System;
using System.Collections.Generic;
using System.Text;
//Julio Israel Aguilar Melgar
namespace Practica1
{
    class ejercicio4
    {
        static void Main(string[] args)
        {
            double num = 0;
            Console.WriteLine("Ingrese un número para sacarle la raíz cuadrada");
            num = Convert.ToDouble(Console.ReadLine());          
            Console.WriteLine("La raíz cuadrada del número " + num + " es: " + Math.Sqrt(num));
            Console.ReadKey();
        }
    }
}
