using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using CSharp.Utilidades;

/*7) Realizá un programa que permita al usuario ingresar 9 caracteres. La computadora debe rotar un 
lugar hacia la derecha el contenido del array de caracteres sin usar un array auxiliar. Luego, 
mostrarlo.*/

namespace CSharp.GuiaSeis
{
    internal class Ejercicio6_7
    {
        public static void Ejecutar()
        {
            const int LENGTH = 7;
            char[] cadena = Utilidades.Utilidades.CargarArrayCaracteres(LENGTH);

            Console.Write("Estos son los chars Ingresados: ");
            Utilidades.Utilidades.MostrarArrayCaracteres(cadena);

            char[] cadenaRotada = rotarCadena(cadena);

            Console.WriteLine();
            Utilidades.Utilidades.MostrarArrayCaracteres(cadenaRotada);
        }

        private static char[] rotarCadena(char[] cadena)
        {
            int lenght = cadena.Length - 1;

            char c = cadena[0];

            for (int i = 0; i < lenght; i++)
            {
                cadena[i] = cadena[i + 1];
            }

            cadena[lenght] = c;

            return cadena;
        }
    }
}
