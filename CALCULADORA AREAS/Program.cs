using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULADORA_AREAS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULADORA DE AREAS");
            Console.WriteLine("1. Area de un cuadrado");
            Console.WriteLine("2. Area de un rectangulo");
            Console.WriteLine("3. Area de un circulo");
            Console.WriteLine("4. Area de un triangulo");
            Console.WriteLine("5. Salir");
            int opcion = 0;
            while (opcion != 5)
            {
                Console.Write("Seleccione una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el lado del cuadrado: ");
                        double lado = Convert.ToDouble(Console.ReadLine());
                        double areaCuadrado = lado * lado;
                        Console.WriteLine($"El área del cuadrado es: {areaCuadrado}");
                        break;
                    case 2:
                        Console.Write("Ingrese la base del rectángulo: ");
                        double baseRectangulo = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese la altura del rectángulo: ");
                        double alturaRectangulo = Convert.ToDouble(Console.ReadLine());
                        double areaRectangulo = baseRectangulo * alturaRectangulo;
                        Console.WriteLine($"El área del rectángulo es: {areaRectangulo}");
                        break;
                    case 3:
                        Console.Write("Ingrese el radio del círculo: ");
                        double radio = Convert.ToDouble(Console.ReadLine());
                        double areaCirculo = Math.PI * radio * radio;
                        Console.WriteLine($"El área del círculo es: {areaCirculo}");
                        break;
                    case 4:
                        Console.Write("Ingrese la base del triángulo: ");
                        double baseTriangulo = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese la altura del triángulo: ");
                        double alturaTriangulo = Convert.ToDouble(Console.ReadLine());
                        double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;
                        Console.WriteLine($"El área del triángulo es: {areaTriangulo}");
                        break;
                    case 5:
                        Console.WriteLine("Saliendo...");
                        break;
                   default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }
        }
    }
}
