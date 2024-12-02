using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Utilidades;

/*8) Realizá un programa que permita al usuario ingresar un número natural. La computadora debe 
mostrar el factorial1 del número.*/

namespace CSharp.GuiaTres
{
    internal class Ejercicio3_8
    {
        public static void Ejecutar()
        {
            int numeroNatural = 3;

            Console.WriteLine($"El factorial de {numeroNatural} es {CalcularFactorial(numeroNatural)}");
        }

        private static int CalcularFactorial(int numero)
        {
            int factorial = 1;

            for (int i = 1; i <= numero; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
