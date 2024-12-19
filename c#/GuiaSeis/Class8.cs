using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Utilidades;

/*8) Realizá un programa que permita al usuario ingresar 9 caracteres. La computadora debe indicar 
si la palabra representada es o no un palíndromo.*/

namespace CSharp.GuiaSeis
{
    internal class Ejercicio6_8
    {
        public static void Ejecutar()
        {
            const int LENGTH = 9;
            char[] cadena = Utilidades.Utilidades.CargarArrayCaracteres(LENGTH);

            Console.Write("Estos son los chars Ingresados: ");
            Utilidades.Utilidades.MostrarArrayCaracteres(cadena);

            bool esPalindromo = reconocerSiEsPalindromo(cadena);

            Console.WriteLine(esPalindromo);
        }

        private static bool reconocerSiEsPalindromo(char[] cadena)
        {
            int lenght = cadena.Length - 1;
            bool esPalindromo = true;
            int i = 0;
            
            while (esPalindromo == true && i < cadena.Length / 2)
            {
                if (cadena[i] != cadena[lenght - i])
                {
                    esPalindromo = false;
                }

                i++;
            }

            return esPalindromo;
        }
    }
}
