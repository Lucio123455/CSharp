using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Utilidades;

/*8) Realizá un programa que permita al usuario ingresar dos números enteros. La computadora debe 
indicar si el mayor es divisible3 por el menor.*/

namespace CSharp.GuiaDos
{
    internal class Ejercicio2_8 
    {
        public static void Ejecutar()
        {
            int numeroA = Utilidades.Utilidades.SolicitarEntero("Ingrese un numero entero");
            int numeroB = Utilidades.Utilidades.SolicitarEntero("Ingrese un numero entero");

            if (DivisorMayorPorMenor(numeroA,numeroB))
            {
                Console.WriteLine("El mayor es divisible por el menor");
            }
            else
            {
                Console.WriteLine("El mayor no es divisible por el menor");
            }
        }

        private static bool DivisorMayorPorMenor(int a, int b)
        {
            return Math.Max(a, b) % Math.Min(a, b) == 0;
        }
    }
}
