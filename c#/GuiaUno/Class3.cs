using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Utilidades;

/*3) Realizá un programa que permita al usuario ingresar el valor salarial de una hora de trabajo y la
cantidad de horas trabajadas por día. La computadora debe mostrar el valor del salario semanal,
asumiendo que trabaja todos los días hábiles y media jornada los sábados*/

namespace CSharp.GuiaUno
{
    internal class Ejericio3
    {
        public static void Ejecutar()
        {
            int valorPorHora = Utilidades.Utilidades.SolicitarEnteroEnRango("Ingrese el valor por hora de trabajo", 1, 10000000);
            int horasPorDia = Utilidades.Utilidades.SolicitarEnteroEnRango("Ingrese las horas trabajadas por dia", 1, 16);

            int horasPorSemana = CalcularHorasTrabajadasPorSemana(horasPorDia);
            int salarioSemanal = CalcularSalarioSemanal(horasPorSemana, valorPorHora);

            Console.WriteLine($"El salario semanal es {salarioSemanal}");
        }

        private static int CalcularHorasTrabajadasPorSemana(int horasPorDia)
        {
            const int CANT_DIAS_HABILES = 5;
            int HORAS_TRABAJADAS_SABADO = horasPorDia / 2;
            return CANT_DIAS_HABILES * horasPorDia + HORAS_TRABAJADAS_SABADO;
        }

        private static int CalcularSalarioSemanal(int horasPorSemana, int valorPorHora)
        {
            return horasPorSemana * valorPorHora;
        }
    }
}
