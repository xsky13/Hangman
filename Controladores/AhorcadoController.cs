using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        static int cuerpo = 0;
        
        public static void Dibujar()
        {
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


        }

        public static string DibujarAhorcado()
        {
            if (cuerpo > 6)
            {
                Console.WriteLine(".\r\n..........._____\r\n..../ ../ ....+ ....\\\r\n...| ..| ....RIP ...|\r\n...| ..| ........... |\r\n...|.. | ............|\r\n\\ .| ..|.. ./\\/\\//\\ .|/ ");

            }
            else
            {
                string cabeza = cuerpo > 0 ? "O" : " ";
                string torso = cuerpo > 1 ? "|" : " ";
                string brazoIzquierdo = cuerpo > 2 ? "/" : " ";
                string brazoDerecho = cuerpo > 3 ? "\\" : " ";
                string piernaIzquierda = cuerpo > 4 ? "/" : " ";
                string piernaDerecha = cuerpo > 5 ? "\\" : " ";

                string[] dibujo = {
                    "  _______  ",
                    " |/     |   ",
                    $" |      {cabeza} ",
                    $" |     {brazoIzquierdo}{torso}{brazoDerecho} ",
                    $" |     {piernaIzquierda} {piernaDerecha}",
                    " |          ",
                    "_|___       "
                };
                foreach (string linea in dibujo)
                {
                    Console.WriteLine(linea);
                }
            }
        }

        public static void ImprimirEpacios(int[] indices, string letra)
        {
            foreach (int indice in indices)
            {
                if (indice != -1) Espacios[indice] = letra;
            }

            foreach (string e in Espacios)
            {
                Console.Write(e);
            }
>>>>>>> 44e1e4245351d244d98c1f6f30f75fe86d22e461
        }

        public static void ImprimirEpacios(int indice, string letra) {
                Espacios[indice] = letra;
            
                foreach (string e in Espacios)
            {

                Console.Write(e);
            }
        }
        public static void Ingresar()
        {
            // abiel
            Console.Write("\n\nIngresa letra: ");
            string nuevaLetra = Console.ReadLine();
            int[] indices = PalabraController.Verificar(nuevaLetra);

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
