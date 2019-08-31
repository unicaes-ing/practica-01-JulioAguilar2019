using System;
using System.Collections.Generic;
using System.Text;

namespace Practica1
{
    class ejercicio6
    {
        static void Main(string[] args)
        {
            double isss = 0.03, afp = 0.0725, renta = 0.0525, sueldo, nsueldo, des;
            string nombre;
            Console.WriteLine("Ingrese el nombre del empleado");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el sueldo del empleado:");
            sueldo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(string.Format("El descuento por el ISSS es: {0:C1}", des =  sueldo * isss));
          
            Console.WriteLine(string.Format("El descuento por el AFP es: {0:C1}", sueldo * afp));
            des += sueldo * afp;
            Console.WriteLine(string.Format("El descuento por la Renta es: {0:C1}",sueldo * renta));
            des += sueldo * renta;
            Console.WriteLine(string.Format("El descuento total es: {0:C1}", des));
            Console.WriteLine(string.Format("El nuevo sueldo es: {0:C1}", nsueldo = sueldo - des));
            Console.ReadKey();
        }
    }
}
