using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman.Controladores
{
    internal class AhorcadoController
    {

        public static string[] Espacios = Enumerable.Repeat("_", PalabraController.palabra.Length).ToArray();

        public static void Dibujar()
        {
            
        }

        public static void ImprimirEpacios(int indice, string letra)
        {
            if (indice != -1) Espacios[indice] = letra;
            foreach (string e in Espacios)
            {
                Console.Write(e);
            }
        }

        public static void Ingresar()
        {
            // abiel
            Console.Write("Ingresa letra: ");
            string nuevaLetra = Console.ReadLine();
            int indicePalabra = PalabraController.Verificar(nuevaLetra);
            ImprimirEpacios(indicePalabra, nuevaLetra);
        }
    }
}
