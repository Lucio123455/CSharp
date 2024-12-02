using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using CSharp.Utilidades;

/*7) Realizá un programa que permita al usuario ingresar un número entero cant. Acto seguido, que
permita ingresar cant números enteros. La computadora debe mostrar cuál fue el mayor número y
en qué posición apareció.*/

namespace CSharp.GuiaTres
{
    internal class Ejercicio3_7
    {
        public static void Ejecutar()
        {
            const int CANT = 5;

            IndicarMayorYSuPosicion(CANT);
        }

        private static void IndicarMayorYSuPosicion(int cant)
        {
            int mayor = 0;
            int posicionMayor = 0;
            
            for (int i = 0; i < cant; i++)
            {
                int numero = Utilidades.Utilidades.SolicitarEntero("Ingrese un numero entero");
                if (numero > mayor)
                {
                    mayor = numero;
                    posicionMayor = i + 1;
                }
            }

            Console.WriteLine($"El mayor es {mayor} y esta en la posicion {posicionMayor}");
        }
    }
}
