using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class ejercicio3
    {
        static void Main(string[] args)
        {
           double num1, num2;
            Console.WriteLine("Ingrese un número decimal");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese un número decimal");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(string.Format("Suma: {0:0.00}", num1 + num2));
            Console.WriteLine(string.Format("Resta {0:0.00}", num1 - num2));
            Console.WriteLine(string.Format("Multiplicacion {0:0.00}", num1 * num2));
            Console.WriteLine(string.Format("Division {0:0.00}", num1 / num2));
            Console.ReadKey();
        }

    }
}
