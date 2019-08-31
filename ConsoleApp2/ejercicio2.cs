using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class ejercicio2
    {
        static void Main(string[] args)

        {
            string nombre, cargo, correo;
            int edad;
            double sueldo;
            DateTime fecha;

            Console.WriteLine("Ingrese el nombre del empleado:"); 
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el cargo del empleado:");
            cargo = Console.ReadLine();
            Console.WriteLine("Ingrese el correo del empleado:");
            correo = Console.ReadLine();
            Console.WriteLine("Ingrese la edad del empleado:");
            edad = Convert.ToInt32(Console.ReadLine());
            fecha = DateTime.Now;    
            Console.WriteLine("Ingrese el sueldo del empleado:");
            sueldo = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Cargo: " + cargo);
            Console.WriteLine("Correo: " + correo);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Sueldo: $" + sueldo);
            Console.WriteLine("Fecha de contratacion: " + fecha);
            Console.ReadKey();
        }

    }
    }

