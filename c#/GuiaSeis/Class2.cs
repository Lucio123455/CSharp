using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Utilidades;

/*2) Realizá un programa que permita al usuario ingresar 8 números enteros. La computadora debe 
mostrar el promedio de estos y cuáles fueron los valores ingresados que lo superaron.*/

namespace CSharp.GuiaSeis
{
    internal class Ejercicio6_2
    { 
        public static void Ejecutar()
        {
            const int LENGTH = 4;
            int[] ints = Utilidades.Utilidades.CargarArrayEnteros(LENGTH);

            Console.Write("Estos son los numeros Ingresados: ");
            Utilidades.Utilidades.MostrarArrayEnteros(ints);

            float promedio = CalcularPromedioArrays(ints);
            Console.WriteLine();

            Console.WriteLine($"El promedio es: {promedio}");
            MostrarValoresQueSuperaronAlPromedio(ints,promedio);
        }

        private static void MostrarValoresQueSuperaronAlPromedio(int[] ints, float promedio)
        {
            Console.Write("Numeros que superaron al promedio: ");    
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] > promedio)
                {
                    Console.Write($" {ints[i]} ");
                }
            }
        }

        private static float CalcularPromedioArrays(int[] ints)
        {
            int suma = 0;

            for (int i = 0; i < ints.Length; i++)
            {
                suma += ints[i];
            }

            return (float)suma / (float)ints.Length;
        }
    }
}
