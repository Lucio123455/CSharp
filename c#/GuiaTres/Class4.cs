using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Utilidades;

/*4) Realizá un programa que permita al usuario ingresar 5 edades. La computadora debe indicar
cuántas edades fueron valores impares mayores que 18.*/

namespace CSharp.GuiaTres
{
    internal class Ejercicio3_4
    {
        public static void Ejecutar()
        {
            const int CANT_EDADES = 5;
            int contImparesMayores18 = contarEdadesImparesMayoresA18(CANT_EDADES);

            Console.WriteLine($"La cantidad de edades impares mayores a 18 es {contImparesMayores18}");
        }

        private static int contarEdadesImparesMayoresA18(int cant)
        {
            int contImparesMayores18 = 0;

            for (int i = 1; i <= cant; i++)
            {
                int edad = Utilidades.Utilidades.SolicitarEntero("Ingrese un edad");
                if (edad % 2 != 0 && !(edad < 18))
                {
                    contImparesMayores18++;
                }
            }

            return contImparesMayores18;
        }
    }
}
