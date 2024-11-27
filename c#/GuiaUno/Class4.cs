using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Utilidades;

/*4) Realizá un programa que permita al usuario ingresar valores del mismo tipo para las variables a
y b. Una vez cargadas, la computadora debe mostrar ambas variables por pantalla, intercambiar
entre sí sus valores (que lo cargado en a quede en b, y viceversa), y volver a mostrarlas.*/

namespace CSharp.GuiaUno
{
    internal class Ejercicio4
    {
        public static void Ejecutar()
        {
            int valorA = Utilidades.Utilidades.SolicitarEntero("Ingrese un valor para a entero");
            int valorB = Utilidades.Utilidades.SolicitarEntero("Ingrese un valor para b entero");
            MostrarVariables(valorA, valorB);
            IntercambiarValor2Variables(valorA, valorB);
        }

        private static void MostrarVariables(int valorA, int valorB)
        {
            Console.WriteLine($"El valor de a es {valorA}");
            Console.WriteLine($"El valor de b es {valorB}");
        }

        private static void IntercambiarValor2Variables(int valorA, int valorB)
        {
            int valorC = 0;
            
            valorC = valorA;
            valorA = valorB;
            valorB = valorC;

            Console.WriteLine($"El valor de a es {valorA}");
            Console.WriteLine($"El valor de b es {valorB}");
        }
    }
}
