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
                   
                }
            }
        }
    }
}
