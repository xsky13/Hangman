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


        public static void Dibujar()
        {

            switch (cantidadErrores)
            {
                case 1: ahorcado.PiernaIzquierda = false; break;
                case 2: ahorcado.PiernaDerecha = false; break;
                case 3: ahorcado.BrazoIzquierda = false; break;
                case 4: ahorcado.BrazoDerecha = false; break;
                case 5: ahorcado.Cuerpo = false; break;
                case 6: ahorcado.Cabeza = false; break;
            }

            string cabeza = ahorcado.Cabeza ? "o" : " ";
            string torso = ahorcado.Cuerpo ? "|" : " ";
            string brazoIzquierdo = ahorcado.BrazoIzquierda ? "/" : " ";
            string brazoDerecho = ahorcado.BrazoDerecha ? "\\" : " ";
            string piernaIzquierda = ahorcado.PiernaIzquierda ? "/" : " ";
            string piernaDerecha = ahorcado.PiernaDerecha ? "\\" : " ";

            string[] dibujo = {
                "  _______  ",
                " |/    |   ",
                $" |     {cabeza}   ",
                $" |    {brazoIzquierdo}{torso}{brazoDerecho}  ",
                $" |    {piernaIzquierda} {piernaDerecha} ",
                " |        ",
                " |__      "
                     };
            Console.WriteLine(string.Join("\n", dibujo));
        }

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

            if (nuevaLetra.Length > 1)
            {
                Console.WriteLine("Solo se puede ingresar una letra. Presione cualquier tecla para seguir...");
                Console.ReadKey(true);

                Ingresar();
            }

            int[] indices = PalabraController.Verificar(nuevaLetra);


            // abiel esto le puse para que se dibuje el coso. si queres tambien hace la logica cuando se gana o se pierde
            // para ganar tenes que combinar todas las letras ingresadas y compararlas con la palabra a adivinar
            Console.Clear();
            Dibujar();
            ImprimirEpacios(indices, nuevaLetra);

        }
    }
}
