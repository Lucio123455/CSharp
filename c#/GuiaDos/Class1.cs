using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Utilidades;

/*1) Realizá un programa que permita al usuario ingresar un número entero. La computadora debe 
indicar si se trata de un número par o impar.*/

namespace CSharp.GuiaDos
{
    internal class Ejercicio2_1
    {
        public static void Ejecutar()
        {
            int numero = Utilidades.Utilidades.SolicitarEntero("Ingrese un numero entero");
            if (DeterminarParidad(numero))
            {
                Console.WriteLine("El numero es par");
            } else
            {
                Console.WriteLine("El numero es impar");
            }
        }

        private static bool DeterminarParidad(int a)
        {
            return a % 2 == 0;
        }
    }
}
