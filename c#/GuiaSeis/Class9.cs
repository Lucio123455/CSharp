using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Utilidades;

/*10) Realizá un programa que permita al usuario ingresar 2 vectores de caracteres, no 
necesariamente de la misma longitud, que representan dos conjuntos. La computadora debe 
mostrar:
A) La unión.
B) La intersección.
C) La diferencia.
D) La diferencia simétrica.*/

namespace CSharp.GuiaSeis
{
    internal class Ejercicio6_9
    {
        public static void Ejecutar()
        {
            Console.Write("Por favor, ingresa la primera cadena: ");
            string cadena1 = Console.ReadLine();

            Console.Write("Por favor, ingresa la segunda cadena: ");
            string cadena2 = Console.ReadLine();

            Console.WriteLine($"Estas son las cadenas ingresadas {cadena1} y {cadena2}");

            MostrarUnion(cadena1, cadena2);
        }

        private static void MostrarUnion(string cadena1, string cadena2)
        {
            string suma = cadena2 + cadena1;


        }

        private static char[] ElminarRepetidos(string cadena)
        {
            char[] union = ['a'];
            bool va = false;
            for (int i = 0; i < cadena.Length; i++)
            {
                for (int j = 0; j < cadena.Length; j++)
                {
                    if (cadena[i] != cadena[j])
                    {
                        va = true;
                    }
                }

                if (va)
                {
                    union[i] = cadena[i]; 
                }
            }

            return union;
        }
    }
}
