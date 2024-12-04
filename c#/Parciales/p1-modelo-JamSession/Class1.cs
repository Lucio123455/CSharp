using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Utilidades;

/*ENUNCIADO
Las “Jam Sessions” son lugares de encuentro entre músicos que en general no se conocen entre sí, 
donde pueden, por turnos, compartir escenario tocando canciones. Se nos pide elaborar un sistema 
que permita controlar el registro de músicos en la exclusiva Jam “Sultans Of Swing”, en EEUU.
Para cada músico que se anote se debe pedir:
• Edad (Entero validado entre 18 y 70)
• Cantidad de horas de permanencia (Entero validado entre 1 y 4)
• Tipo de instrumento: (Caracter válido según las posibilidades a continuación)
o 'G': Guitarra
o 'B': Bajo
o 'D': Batería
o 'K': Teclados
La carga de datos termina cuando se responde 'N' a la pregunta "Desea ingresar otro? [S/N]".
Todos los músicos deben abonar un costo de entrada de 1 dólar cada uno por hora de permanencia.
▪ Los bajistas tienen un 10% de descuento.
▪ Los tecladistas mayores de 35 años tienen un 20% de descuento.
▪ Los bateristas abonan 10 centavos extra por cada hora, a partir de la tercera hora.
El programa debe calcular y mostrar, de forma clara y ordenada:
A) Los datos del músico (edad, horas e instrumento) que más abonó en concepto de entrada.
B) El porcentaje de guitarristas que asistieron.
C) El promedio de horas de permanencia.*/

namespace CSharp.Parciales.p1_modelo_JamSession
{
    internal class Modelo_Jam_Sessions
    {
        public static void Ejecutar()
        {
            JamSession();
        }

        private static void JamSession()
        {
            char entrada = ' ';
            int edad = 0;
            int horasPermanencia = 0;
            char instrumento = ' ';
            entrada = ' ';
            float mayorAbono = 0;
            int cantidadDeEntradas= 0;
            int cantidadHoras = 0;
            int cantidadGuitarristas = 0;
            int mayorEdad = 0;
            int mayorHoras = 0;
            char mayorInstrumento = ' ';

            Console.WriteLine("Ingrese un musico");
            while (entrada != 'N')
            {
                edad = Utilidades.Utilidades.SolicitarEnteroEnRango("Ingrese la edad", 18, 70);
                horasPermanencia = Utilidades.Utilidades.SolicitarEnteroEnRango("Ingrese las horas de permanencia", 1, 4);
                instrumento = ValidarInstrumento("Ingrese el instrumento 'G': Guitarra - 'B': Bajo - 'D': Batería - 'K': Teclados");

                float abono = CalcularAbonoDelMusico(edad, horasPermanencia, instrumento);
                if (abono > mayorAbono)
                {
                    mayorAbono = abono;
                    mayorEdad = edad;
                    mayorHoras = horasPermanencia;
                    mayorInstrumento = instrumento;
                }

                cantidadGuitarristas += ContarGuitarristas(instrumento);
                cantidadDeEntradas++;
                cantidadHoras += horasPermanencia;
                entrada = Utilidades.Utilidades.SolicitarSIoNO("Quiere ingresar un musico mas?");
            }

            Console.WriteLine($"La de edad del que mas pago es {mayorEdad}, las hora {mayorHoras}, instrumento {mayorInstrumento}");
            Console.WriteLine($"El porcentaje de guitarristas es {CalcularPorcentajeGuitarristas(cantidadGuitarristas, cantidadDeEntradas)}");
            Console.WriteLine($"El promedio de horas es {cantidadHoras / cantidadDeEntradas}");
        }

        private static float CalcularPorcentajeGuitarristas(int cant, int total)
        {
            return (cant * 100) / total ;
        }

        private static int ContarGuitarristas(char instrumento)
        {
            int guitarristas = 0;

            if (instrumento == 'G')
            {
                guitarristas++;
            }

            return guitarristas;
        }

        private static float CalcularAbonoDelMusico(int edad, int horas, char instrumento)
        {
            const float VALOR_POR_HORA = 1;
            float abono = horas * VALOR_POR_HORA;

            if (instrumento == 'B')
            {
                abono = abono * 0.9f; 
            }
            else if (instrumento == 'K' && edad > 35)
            {
                abono = abono * 0.8f; 
            }
            else if (instrumento == 'D' && horas >= 3)
            {
                abono = abono + ((horas - 2) * 0.1f); 
            }

            return abono;
        }

        private static char ValidarInstrumento(string mensaje)
        {
            char genero;
            bool esValido = false;

            do
            {
                Console.WriteLine(mensaje);
                string entrada = Console.ReadLine();

                esValido = char.TryParse(entrada, out genero) && (genero == 'G' || genero == 'B' || genero == 'K' || genero == 'D');

                if (!esValido)
                {
                    Console.WriteLine("ERROR no válido. Por favor ingrese 'D', 'G', 'B' o 'K'.");
                }
            }
            while (!esValido);

            return genero;
        }
    }    
}
