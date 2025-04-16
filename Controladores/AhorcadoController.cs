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

        public static Personaje ahorcado = new Personaje();


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

            Console.WriteLine("\nLetras equivocadas: ");
            for (int i = 0; i < letrasEquivocadas.Length; i++) 
            {
                Console.Write(letrasEquivocadas[i]);
            }
        }

        public static void Error(string? mensaje = "Por favor ingrese una letra. Presione cualquier tecla para seguir...")
        {
            Console.WriteLine(mensaje);
            Console.ReadKey(true);

            Ingresar();
        }

        public static void Ingresar()
        {

            Console.Write("\n\nIngresa letra: ");
            string nuevaLetra = Console.ReadLine();

            if (nuevaLetra == null)
            {
                Error();
            }

            if (nuevaLetra.Length != 1)
            {
                Error();
            }

            int[] indices = PalabraController.Verificar(nuevaLetra);

            Console.Clear();
            Dibujar();
            ImprimirEpacios(indices, nuevaLetra);

            VerificarFin();
        }

        public static void VerificarFin()
        {
            string espaciosString = string.Join("", Espacios);
            if (espaciosString == PalabraController.palabra)
            {
                Terminar(1);
            }
            else if (cantidadErrores >= 6)
            {
                Terminar(0);
            }
            else
            {
                Ingresar();
            }
        }

        public static void Terminar(int opcion)
        {
            Console.Clear();
            switch (opcion)
            {
                case 0: Console.WriteLine("PERDISTE"); break;
                case 1: Console.WriteLine("GANASTE"); break;
            }
            Console.WriteLine("Toca cualquier tecla para continuar... ");
            Console.ReadKey();
            Program.Menu();
        }
    }
}
