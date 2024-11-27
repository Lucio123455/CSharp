using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Utilidades;

/*5) Realizá un programa que permita al usuario ingresar el valor unitario de cierto artículo y la
cantidad de artículos vendidos por un vendedor, del cual se sabe que gana un sueldo fijo de $14000
más el 16% del monto total vendido. Con tales datos, la computadora debe calcular el sueldo
mensual del vendedor y mostrarlo.*/

namespace CSharp.GuiaUno
{
    internal class Ejercicio5
    {
        public static void Ejecutar()
        {
            float valorArticulo = Utilidades.Utilidades.SolicitarFloatEnRango("Ingrese el valor del articulo", 1, 100000000);
            int cantidadVendidos = Utilidades.Utilidades.SolicitarEnteroEnRango("Ingrese la cantidad de articulos vendidos", 1, 10000000);
            const int SUELDO_FIJO = 14000;
            const float PORCENTAJE_MONTO_TOTAL = 0.16f;
            
            float montoTotal = CalcularMontoTotal(valorArticulo,cantidadVendidos);
            float sueldoTotal = CalcularSueldoTotal(SUELDO_FIJO, montoTotal, PORCENTAJE_MONTO_TOTAL);

            Console.WriteLine($"El sueldo mensual es {sueldoTotal:C}");
        }

        private static float CalcularMontoTotal(float valorArticulo, int cantidadVendidos)
        {
            return valorArticulo * cantidadVendidos;
        }

        private static float CalcularSueldoTotal(int sueldoFijo, float montoTotal, float porcentajeMontoTotal)
        {
            return sueldoFijo + (montoTotal * porcentajeMontoTotal);
        }
    }
}
