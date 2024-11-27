using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Utilidades;

/*2) Realizá un programa que permita al usuario ingresar la cantidad de inscriptos a una conferencia 
y la cantidad de asientos disponibles en el auditorio. La computadora debe indicar si alcanzan los 
asientos, en caso contrario, indicar cuántos faltan para que todos los inscriptos puedan sentarse.*/

namespace CSharp.GuiaDos
{
    internal class Ejercicio2_2
    {
        public static void Ejecutar()
        {
            int cantidadInscriptos = Utilidades.Utilidades.SolicitarEntero("Ingrese la cantidad de inscrptos");
            int cantidadAsientos = Utilidades.Utilidades.SolicitarEntero("Ingrese la cantidad de asientos disponibles");

            if (DeterminarDisponibilidadDeAsientos(cantidadInscriptos,cantidadAsientos))
            {
                Console.WriteLine("Alcanzan los asientos");
            }
            else
            {
                Console.WriteLine($"Faltarian agregar {cantidadInscriptos - cantidadAsientos} asientos");
            }

        }

        private static bool DeterminarDisponibilidadDeAsientos(int cantidadInscriptos, int cantidadAsientos)
        {
            return cantidadAsientos > cantidadInscriptos;
        }
    }
}
