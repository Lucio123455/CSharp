using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Utilidades;

/*3) Realizá un programa que permita al usuario ingresar dos números enteros. La computadora debe 
indicar cuál de ellos es el mayor.*/

namespace CSharp.GuiaDos
{
    internal class Ejercicio2_3
    {
        public static void Ejcutar()
        {
            int numeroA = Utilidades.Utilidades.SolicitarEntero("Ingrese un numero entero");
            int numeroB = Utilidades.Utilidades.SolicitarEntero("Ingrese otro numero entero");

            if (DeterminarMayor2Num(numeroA,numeroB))
            {
                Console.WriteLine($"El mayor es {numeroA}");
            } 
            else
            {
                Console.WriteLine($"El mayor es el {numeroB}");
            }
        }
        private static bool DeterminarMayor2Num(int a, int b)
        {
            return a > b;
        }
    }

    
}
