using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Utilidades;

/*6) Realizá un programa que permita al usuario ingresar la edad y el sueldo de cierto empleado. La 
computadora muestra el monto del aporte al sindicato que se debe descontar del salario del 
empleado, según el siguiente cuadro: 
Escala salarial Porcentaje a descontar
Menos de $20000 0.7%
Entre $20000 y $29999 1.4%
Entre $30000 y $39999 2.1%
$40000 o más 2.8%
Además, si la persona tiene 30 años o menos, se cobra un 30% adicional del valor del aporte.*/

namespace CSharp.GuiaDos
{
    internal class Ejercicio2_6
    {
        public static void Ejecutar()
        {
            int edad = Utilidades.Utilidades.SolicitarEntero("Ingrese a edad");
            int sueldo = Utilidades.Utilidades.SolicitarEntero("Ingrese el sueldo");

            if (edad <= 30)
            {
                Console.WriteLine($"El sueldo del empleado es {DescuentoSindicato(sueldo) + DescuentAdicional(DescuentoSindicato(sueldo))}");

            } 
            else
            {
                Console.WriteLine($"El sueldo del empleado es {DescuentoSindicato(sueldo)}");
            }
        }

        public static float DescuentoSindicato(int sueldo)
        {
            float descuento = 0;
            
            if (sueldo < 20000)
            {
                descuento = sueldo * 0.007f;
            }
            if (sueldo >= 20000 && sueldo < 30000)
            {
                descuento = sueldo * 0.014f; 
            }
            if (sueldo >= 30000 && sueldo < 40000)
            {
                descuento = sueldo * 0.021f;
            }
            if (sueldo >= 40000)
            {
                descuento = sueldo * 0.028f;
            }

            return descuento;
        }

        private static float DescuentAdicional(float valor)
        {
            return valor * 0.3f;
        }
    }
}
