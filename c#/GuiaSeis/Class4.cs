using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CSharp.Utilidades;

/*4) Realizá un programa que permita al usuario ingresar 9 números enteros. La computadora debe 
mostrar el valor máximo y la cantidad de veces que se ingresó tal valor.*/

namespace CSharp.GuiaSeis
{
    internal class Ejercicio6_4
    {
        public static void Ejecutar()
        {
            const int LENGTH = 6;
            int[] ints = Utilidades.Utilidades.CargarArrayEnteros(LENGTH);

            Console.Write("Estos son los numeros Ingresados: ");
            Utilidades.Utilidades.MostrarArrayEnteros(ints);

            Console.WriteLine();

            Console.WriteLine($"La cantidad de veces que salio el mayor fue {CalcularLaCantidadDelValorMaximo(ints)}");
        }

        private static int CalcularLaCantidadDelValorMaximo(int[] numeros)
        {
            int max = numeros.Max();
            return numeros.Count(x => x == max);
        }

        /*private static int CalcularLaCantidadDelValorMaximo(int[] ints)
        {
            int mayor = ints[0];
            int cantMayor = 0;

            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] > mayor)
                {
                    mayor = ints[i];
                    cantMayor = 0;
                }
                if (ints[i] == mayor)
                {
                    cantMayor++;
                }
            }

            return cantMayor;
        }*/
    }
}
