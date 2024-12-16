using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Utilidades;

/*5) Realizá un programa que permita al usuario ingresar 8 números enteros. La computadora debe 
mostrar la suma de los números ingresados en las posiciones pares*/

namespace CSharp.GuiaSeis
{
    internal class Ejercicio6_5
    {
        public static void Ejecutar()
        {
            const int LENGTH = 6;
            int[] ints = Utilidades.Utilidades.CargarArrayEnteros(LENGTH);

            Console.Write("Estos son los numeros Ingresados: ");
            Utilidades.Utilidades.MostrarArrayEnteros(ints);

            Console.WriteLine($"La suma de los que estan en posiciones pares es {SumarNumerosEnLasPosicionesPares(ints)}");
        }

        private static int SumarNumerosEnLasPosicionesPares(int[] ints)
        {
            var numerosPares = ints.Where(n => n % 2 == 0).ToArray();
            return numerosPares.Sum();
        }
    }
}
