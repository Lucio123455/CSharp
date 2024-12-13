using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Utilidades;

/*3) Realizá un programa que permita al usuario ingresar 7 números enteros. La computadora debe 
mostrar aquellos que sean múltiplos del último número ingresado*/

namespace CSharp.GuiaSeis
{
    internal class Ejercicio6_3
    {
        public static void Ejecutar()
        {
            const int LENGTH = 4;
            int[] ints = Utilidades.Utilidades.CargarArrayEnteros(LENGTH);

            Console.Write("Estos son los numeros Ingresados: ");
            Utilidades.Utilidades.MostrarArrayEnteros(ints);

            Console.WriteLine();
            MostrarMultiplosDelUltimoNumero(ints);
        }

        private static void MostrarMultiplosDelUltimoNumero(int[] ints)
        {
            int ultimo = ints[ints.Length - 1];

            Console.Write($"Los multiplos de {ultimo} son: ");
            for (int i = 0; i < ints.Length ; i++)
            {
                if (ints[i] % ultimo == 0)
                {
                    Console.Write(ints[i] + " ");
                }
            }
        }
    }
}
