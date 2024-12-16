using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Utilidades;

/*6) Realizá un programa que permita al usuario ingresar 9 caracteres. La computadora debe invertir 
el contenido del array de caracteres sin usar un array auxiliar. Luego, mostrarlo.*/

namespace CSharp.GuiaSeis
{
    internal class Ejercicio6_6
    {
        public static void Ejecutar()
        {
            const int LENGTH = 7;
            char[] chars = Utilidades.Utilidades.CargarArrayCaracteres(LENGTH);

            Console.Write("Estos son los chars Ingresados: ");
            Utilidades.Utilidades.MostrarArrayCaracteres(chars);

            char[] cadenaInvertida = invertirCadena(chars);

            Console.WriteLine();
            Utilidades.Utilidades.MostrarArrayCaracteres(cadenaInvertida);


        }

        private static char[] invertirCadena(char[] chars)
        {
            int lenght = chars.Length - 1;

            for (int i = 0; i < chars.Length / 2; i++)
            {
                chars[i] = chars[lenght - i];
                chars[lenght - i] = chars[i];
            }

            return chars;
        }
    }
}
