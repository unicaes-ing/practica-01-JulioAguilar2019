using System;
using System.Collections.Generic;
using System.Text;

namespace Practica1
{
    class ejercicio5
    {
        static void Main(string[] args)
        {
            double trimestre = 0.0, total, prom;
            Console.WriteLine("Ingrese el total de ventas de cada trimestre para calcular el promedio de ventas por trimestre");
            Console.WriteLine();
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("Ingrese el total de ventas correspondiente al trimestre " + i);
                trimestre += Convert.ToDouble(Console.ReadLine());
                
             }
            total = trimestre;
            prom = total / 4;
             Console.WriteLine("El promedio de ventas por trimestre es: " + prom);
            Console.ReadKey();
        }
    }
}
