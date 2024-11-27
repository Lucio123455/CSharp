using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Utilidades;

/*5) Realizá un programa que permita al usuario ingresar su edad (entre 1 y 120 años) y su género 
('F' para mujeres, 'M' para hombres). La computadora debe indicar si la persona está en edad de 
jubilarse1
. En caso de haber ingresado valores erróneos (edad fuera de rango o género inválido), 
informar tal situación.*/

namespace CSharp.GuiaDos
{
    internal class Ejercicio2_5
    {
        public static void Ejecutar()
        {
            int edad = Utilidades.Utilidades.SolicitarEnteroEnRango("Ingrese la edad", 1, 120);
            char genero = Utilidades.Utilidades.SolicitarGenero("Ingrese el genero");

            if (DeterminarJubilacion(edad, genero))
            {
                Console.WriteLine("Se jubila");
            }
            else
            {
                Console.WriteLine("No se jubila");
            }
        }

        private static bool DeterminarJubilacion(int edad, char genero)
        {
            bool seJubila = false;
            const int JUB_HOMBRE = 65;
            const int JUB_MUJER = 60;

            if (edad > JUB_HOMBRE)
            {
                seJubila = true;
            }
            else if (genero == 'F' && edad > JUB_MUJER)
            {
                seJubila = true;
            } 

            return seJubila;
        }
    }
}
