using System;

namespace Triangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la longitud del primer lado del triángulo:");
            double lado1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la longitud del segundo lado del triángulo:");
            double lado2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la longitud del tercer lado del triángulo:");
            double lado3 = Convert.ToDouble(Console.ReadLine());

            if (lado1 <= 0 || lado2 <= 0 || lado3 <= 0)
            {
                Console.WriteLine("Las longitudes de los lados deben ser mayores a cero.");
            }
            else if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("El triángulo es equilátero.");
            }
            else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
            {
                Console.WriteLine("El triángulo es isósceles.");
            }
            else
            {
                Console.WriteLine("El triángulo es escaleno.");
            }
        }
    }
}
