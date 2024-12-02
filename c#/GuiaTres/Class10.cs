using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Utilidades;

/*18) Realizá un programa que permita al usuario ingresar 12 valores, de a uno por vez, que 
representan los sueldos mensuales que percibió un empleado durante un año. Si durante la carga 
de los sueldos mensuales se detecta un valor negativo, esto indica que aún no se ha cobrado el mes 
en curso, por lo tanto, deben dejar de ingresarse datos. La computadora debe mostrar el sueldo 
anual percibido (total o parcial). */

namespace CSharp.GuiaTres
{
    internal class Ejercicio3_18
    {
        public static void Ejecutar()
        {
            const int MESES = 12;
            int sueldoAnual = calcularSueldoTotalDelEmpleado(MESES);
            Console.WriteLine($"el sueldo es {sueldoAnual}");
        }

        private static int calcularSueldoTotalDelEmpleado(int meses)
        {
            int total = 0;
            int entrada = 0;
            int i = 0;

            while (i < meses && entrada >= 0)
            {
                entrada = Utilidades.Utilidades.SolicitarEntero("ingrese el sueldo de este mes");
                total = total + entrada;
                i++;
            }

            return total;
        }
    }
}
