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

        public static char SolicitarSIoNO(string mensaje)
        {
            char genero;
            bool esValido = false;

            do
            {
                Console.WriteLine(mensaje);
                string entrada = Console.ReadLine();

                esValido = char.TryParse(entrada, out genero) && (genero == 'S' || genero == 's' || genero == 'N' || genero == 'n');

                if (!esValido)
                {
                    Console.WriteLine("ERROR no válido. Por favor ingrese 'S', 's', 'N' o 'n'.");
                }
            }
            while (!esValido);

            return genero;
        }

        public static int[] CargarArrayEnteros(int length)
        {
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = SolicitarEntero($"Ingrese el {i + 1} numero hasta {length}");
            }

            return array;
        }

        public static void MostrarArrayEnteros(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        public static char[] CargarArrayCaracteres(int length)
        {
            char[] array = new char[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = SolicitarCaracter("Ingrese un caracter");
            }

            return array;
        }

        public static void MostrarArrayCaracteres(char[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
        }

        private static char SolicitarCaracter(string mensaje)
        {
            char caracter;
            bool esValido;

            do
            {
                Console.WriteLine(mensaje);
                esValido = char.TryParse(Console.ReadLine(), out caracter);

                if (!esValido)
                {
                    Console.WriteLine("Por favor, ingrese un número válido.");
                }
            } while (!esValido);

            return caracter;
        }

    }
}

