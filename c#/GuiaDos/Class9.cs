using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Utilidades;

/*9) Realizá un programa que permita al usuario ingresar los lados a, b y c de un triángulo. La 
computadora informa si el triángulo es o no válido4
. En caso afirmativo, además informa si es 
equilátero, isósceles o escaleno.*/

namespace CSharp.GuiaDos
{
    internal class Ejercicio2_9
    {
        public static void Ejecutar()
        {
            int ladoA = 5;
            int ladoB = 5;
            int ladoC = 5;

            IndicarCaracteristaDeUnTriangulo(ladoA, ladoB, ladoC);
        }

        private static void IndicarCaracteristaDeUnTriangulo(int a, int b, int c)
        {
            if (!(a > (b + c) || b > (c + a) || c > (a + b)) || a > 0 || b > 0 || c > 0)
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("El triangulo es equilatero");
                }
                if (a != b && b != c && c != a)
                {
                    Console.WriteLine("El triangulo es escaleno");
                }
                if ((a == b && b != c) || (b == c && c != a) || (c == a && a != b))
                {
                    Console.WriteLine("El triangulo es isosceles");
                }
            }
            else
            {
                Console.WriteLine("El triangulo es invalido");
            }
        }
    }
}
