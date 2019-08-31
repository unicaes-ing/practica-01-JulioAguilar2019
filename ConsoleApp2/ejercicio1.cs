using System;

namespace ConsoleApp2
{
    class ejercicio1
    {
        static void Main(string[] args)
        {
            string nombre, especie;
            int edad; 
            Console.WriteLine("Ingrese el nombre de su mascota");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la especie de su mascota");
            especie = Console.ReadLine();
            Console.WriteLine("Ingrese la edad de su mascota");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mi mascota se llama: " + nombre + " es un: " + especie + "  y tiene " + edad + " años");
            Console.ReadKey();
        }
    }
}
