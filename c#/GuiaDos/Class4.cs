using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Utilidades;

/*4) Realizá un programa que permita al usuario ingresar tres números enteros. La computadora debe 
indicar cuál de ellos es el mayor.*/

namespace CSharp.GuiaDos
{
    internal class Ejercicio2_4
    {
        public static void Ejecutar()
        {
            int numeroA = Utilidades.Utilidades.SolicitarEntero("Ingrese un entero");
            int numeroB = Utilidades.Utilidades.SolicitarEntero("Ingrese un entero");
            int numeroC = Utilidades.Utilidades.SolicitarEntero("Ingrese un entero");

            Console.WriteLine($"El mayor es {Math.Max(numeroA, Math.Max(numeroB,numeroC))}");
        }
    }
}
