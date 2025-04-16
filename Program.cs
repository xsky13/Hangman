using Hangman.Controladores;
using Hangman.Modelos;

namespace Hangman
{
    internal class Program
    {

        static void CorrerJuego()
        {
            Console.Clear();
            AhorcadoController.Dibujar();
            AhorcadoController.ImprimirEpacios([-1]);
            AhorcadoController.Ingresar();
        }

        public static void Menu()
        {
            Console.Clear();
            Console.Write("Entre una opcion: ");

            Console.WriteLine("\n\n1 - Empezar juego");
            Console.WriteLine("2 - Agregar palabra");
            Console.WriteLine("3 - Salir");


            int opcion;
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("\nIngrese un numero valido por favor");
                Console.WriteLine("Toque cualquier tecla para continuar...");
                Console.ReadKey();
                Menu();
            }

            switch (opcion)
            {
                case 1:
                    {

                        PalabraController.palabra = PalabraController.Seleccionar();
                        CorrerJuego();
                        //ResetearJuego();
                        break;
                    }
                case 2:
                    {
                        PalabraController.Agregar();
                        Menu();
                        break;
                    }
                case 3: return;
                default: Menu(); break;

            }
        }
        public static void ResetearJuego()
        {
            AhorcadoController.cantidadErrores = 0;
            AhorcadoController.letrasEquivocadas = new string[0];
            AhorcadoController.ahorcado= new Personaje();
            PalabraController.palabra = PalabraController.Seleccionar();
            AhorcadoController.Espacios = Enumerable.Repeat("_", PalabraController.palabra.Length).ToArray();
        }

        static void Main(string[] args)
        {

            Menu();
        }


    }
}

