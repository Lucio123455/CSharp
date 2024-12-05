using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Utilidades;

/*1) Realizá un programa que permita al usuario ingresar 6 números enteros. La computadora debe 
mostrar cada elemento leído en un solo renglón. Luego, mostrar lo mismo, pero de forma invertida.*/

namespace CSharp.GuiaSeis
{
    internal class Ejercicio6_1
    {
        public static void Ejecutar()
        {
            const int LONG = 6;
            int[] enteros = CargarArray(LONG);
            
            MostrarArrayEnteros(enteros);
            Console.WriteLine();
            MostrarInvertido(enteros);
        }

        private static int[] CargarArray(int length)
        {
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = Utilidades.Utilidades.SolicitarEntero($"Ingrese el {i + 1} numero hasta {length}");
            }

            return array;
        }

        private static void MostrarArrayEnteros(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        private static void MostrarInvertido(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
