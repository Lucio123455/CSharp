using System;

namespace CSharp.Utilidades
{
    public static class Utilidades
    {
        public static int SolicitarEntero(string mensaje)
        {
            int numero;
            bool esValido;

            do
            {
                Console.WriteLine(mensaje);
                esValido = int.TryParse(Console.ReadLine(), out numero);

                if (!esValido)
                {
                    Console.WriteLine("Por favor, ingrese un número válido.");
                }
            } while (!esValido);

            return numero;
        }

        public static int SolicitarEnteroEnRango(string mensaje, int min, int max)
        {
            int numero;
            bool esValido;

            do
            {
                Console.WriteLine($"{mensaje} (Entre {min} y {max}):");
                esValido = int.TryParse(Console.ReadLine(), out numero);

                if (!esValido || numero < min || numero > max)
                {
                    Console.WriteLine($"Por favor, ingrese un número válido entre {min} y {max}.");
                    esValido = false;
                }
            } while (!esValido);

            return numero;
        }

        public static float SolicitarFloat(string mensaje)
        {
            float numero;
            bool esValido;

            do
            {
                Console.WriteLine(mensaje);
                esValido = float.TryParse(Console.ReadLine(), out numero);

                if (!esValido)
                {
                    Console.WriteLine("Por favor, ingrese un número válido.");
                }
            } while (!esValido);

            return numero;
        }

        public static float SolicitarFloatEnRango(string mensaje, int min, int max)
        {
            float numero;
            bool esValido;

            do
            {
                Console.WriteLine($"{mensaje} (Entre {min} y {max}):");
                esValido = float.TryParse(Console.ReadLine(), out numero);

                if (!esValido || numero < min || numero > max)
                {
                    Console.WriteLine($"Por favor, ingrese un número válido entre {min} y {max}.");
                    esValido = false;
                }
            } while (!esValido);

            return numero;
        }

        public static bool DeterminarParidad(int a)
        {
            return a % 2 == 0;
        }

        public static char SolicitarGenero(string mensaje)
        {
            char genero;
            bool esValido = false;

            do
            {
                Console.WriteLine(mensaje);
                string entrada = Console.ReadLine();

                esValido = char.TryParse(entrada, out genero) && (genero == 'F' || genero == 'f' || genero == 'M' || genero == 'm');

                if (!esValido)
                {
                    Console.WriteLine("Género no válido. Por favor ingrese 'F', 'f', 'M' o 'm'.");
                }
            }
            while (!esValido);  

            return genero;
        }

    }
}

