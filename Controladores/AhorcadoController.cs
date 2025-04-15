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

        static int cuerpo = 0;

        public static int cantidadErrores = 0;


        static Personaje ahorcado = new Personaje();

        //public static void Dibujar()
        //{
        //while (true)
        //{
        //    Console.Clear();
        //    Console.WriteLine(DibujarAhorcado());
        //    Console.WriteLine($"Partes del cuerpo dibujadas: {cuerpo}");
        //    Console.Write($"Ingrese 'a' para dibujar una parte, 'r' para deshacer una parte o 'q' para salir : ");
        //    string entrada = Console.ReadLine().ToLower();

        //    if (entrada == "a")
        //    {
        //        if (cuerpo < 7)
        //        {
        //            cuerpo++;
        //        }
        //        else
        //        {
        //            Console.WriteLine("No se pueden agregar más partes del cuerpo.");
        //            Console.ReadKey();
        //        }
        //    }
        //    else if (entrada == "r")
        //    {
        //        if (cuerpo > 0)
        //        {
        //            cuerpo--;
        //        }
        //    }
        //    else if (entrada == "q")
        //    {
        //        Console.WriteLine("Saliendo del programa.");
        //        break;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Entrada inválida. Por favor, ingrese 'a', 'r' o 'q'.");
        //        Console.ReadKey();
        //    }
        //}


        //}

        //public static string DibujarAhorcado()
        //{
        //if (cuerpo > 6)
        //{
        //    Console.WriteLine(".\r\n..........._____\r\n..../ ../ ....+ ....\\\r\n...| ..| ....RIP ...|\r\n...| ..| ........... |\r\n...|.. | ............|\r\n\\ .| ..|.. ./\\/\\//\\ .|/ ");
        //    return "";
        //}
        //else
        //{
        //    string cabeza = cuerpo > 0 ? "O" : " ";
        //    string torso = cuerpo > 1 ? "|" : " ";
        //    string brazoIzquierdo = cuerpo > 2 ? "/" : " ";
        //    string brazoDerecho = cuerpo > 3 ? "\\" : " ";
        //    string piernaIzquierda = cuerpo > 4 ? "/" : " ";
        //    string piernaDerecha = cuerpo > 5 ? "\\" : " ";

        //    string[] dibujo = {
        //        "  _______  ",
        //        " |/     |   ",
        //        $" |      {cabeza} ",
        //        $" |     {brazoIzquierdo}{torso}{brazoDerecho} ",
        //        $" |     {piernaIzquierda} {piernaDerecha}",
        //        " |          ",
        //        "_|___       "
        //    };
        //    return string.Join("\n", dibujo);
        //}
        //}

        //public static void Dibujar()
        //{

        //    switch(cantidadErrores)
        //    {
        //        case 1: ahorcado.PiernaIzquierda = false; break;
        //        case 2: ahorcado.PiernaDerecha = false; break;
        //        case 3: ahorcado.BrazoIzquierda = false; break;
        //        case 4: ahorcado.BrazoDerecha = false; break;
        //        case 5: ahorcado.Cuerpo = false; break;
        //        case 6: ahorcado.Cabeza = false; break;
        //    }

        //    Console.WriteLine(" O");
        //    Console.WriteLine((ahorcado.BrazoIzquierda ? "=" : " ") + (ahorcado.Cuerpo ? "|" : "") + (ahorcado.BrazoDerecha ? "=" : ""));
        //    Console.WriteLine((ahorcado.PiernaIzquierda ? "/ " : "  ") + (ahorcado.PiernaDerecha ? "\\" : ""));

        //    Console.WriteLine();
        //}
        
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
            // abiel
            Console.Clear();

            Dibujar();
            ImprimirEpacios();

            Console.Write("\n\nIngresa letra: ");
            string nuevaLetra = Console.ReadLine();
            int[] indices = PalabraController.Verificar(nuevaLetra);

            Console.Clear();
            Dibujar();
            ImprimirEpacios(indices, nuevaLetra);


            string fullString = string.Join("", Espacios);
            if (fullString == PalabraController.palabra)
            {
                Console.WriteLine("Listo!!");
            } else
            {
                Ingresar();
            }
        }
    }
}
