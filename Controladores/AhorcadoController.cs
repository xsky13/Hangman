using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hangman.Modelos;

namespace Hangman.Controladores
{
    internal class AhorcadoController
    {
        public static string[] Espacios = Enumerable.Repeat("_", PalabraController.palabra.Length).ToArray();

        public static int cantidadErrores = 0;

        public static string[] letrasEquivocadas = { };

        static Personaje ahorcado = new Personaje();



        public static void ImprimirEpacios(int[]? indices = null, string? letra = null)
        {
            if (indices != null)
            {
                foreach (int indice in indices)
                {
                    if (indice != -1) Espacios[indice] = letra;
                }
            }

            foreach (string e in Espacios)
            {
                Console.Write(e);
            }

            
        }

        public static void Ingresar()
        {
            Console.Write("\n\nIngresa letra: ");
            string nuevaLetra = Console.ReadLine();
            int[] indices = PalabraController.Verificar(nuevaLetra);

            Console.Clear();
            Dibujar();
            ImprimirEpacios(indices, nuevaLetra);

            Ingresar();
        }
    }
}
