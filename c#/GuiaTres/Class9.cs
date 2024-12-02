using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Utilidades;

/*9) Realizá un programa que permita al usuario ingresar un número natural n. La computadora debe 
mostrar los primeros n múltiplos de 3 excepto aquellos que sean a la vez múltiplos de 5.*/

namespace CSharp.GuiaTres
{
    internal class Ejercicio3_9
    {
        public static void Ejecutar()
        {
            int numeroNatural = 10;

            BuscarMultiplosDe3PeroNoDe5(numeroNatural);
        }

        private static void BuscarMultiplosDe3PeroNoDe5(int numero)
        {
            int i = 1;

            while (i <= numero)
            {
                int multiploDeTres = i * 3;
                if (esMultiploDeCinco(multiploDeTres))
                {
                    numero++;
                }
                else
                {
                    Console.Write($"{multiploDeTres} ");
                }

                i++;
            }
        }

        private static bool esMultiploDeCinco(int numero)
        {
            return numero % 5 == 0;
        }
    }
}
