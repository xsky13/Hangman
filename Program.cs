using System.Linq;
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

        public static void ImprimirTabla(string[][] filas)
        {

            int index = 0;
            while (index < Console.WindowHeight/3)
            {
                Console.WriteLine();
                index++;
            }
            string[] columnas = filas[0];
            string[][] filasRestantes = filas.Skip(1).ToArray();

            string biggest0Word = "";
            string biggest1Word = "";

            int anchoTabla = (biggest0Word.Length + 2) + (biggest1Word.Length + 2) + 3;
            float espacio = (float)((Console.WindowWidth - anchoTabla) / 2.37);
            string espacios = new string(' ', (int)espacio);


            // loop para encontrar la palabra mas grande
            for (int i = 0; i < filas.Length; i++)
            {
                if (filas[i][0].Length > biggest0Word.Length)
                {
                    biggest0Word = filas[i][0];
                }

                if (filas[i][1].Length > biggest1Word.Length)
                {
                    biggest1Word = filas[i][1];
                }
            }


            Console.Write(espacios + '╔' + new string('═', biggest0Word.Length + 2) + "╦");
            Console.Write(new string('═', biggest1Word.Length + 2) + '╗');
            Console.WriteLine();

            Console.Write(espacios + "║ ");
            Console.Write(columnas[0] + new string(' ', biggest0Word.Length - columnas[0].Length));
            Console.Write(" ║ ");

            Console.Write(columnas[1] + new string(' ', biggest1Word.Length - columnas[1].Length));
            Console.WriteLine(" ║");

            Console.WriteLine(espacios + "╠" + new string('═', biggest0Word.Length + 2) + "╬" + new string('═', biggest1Word.Length + 2) + "╣");

            // loop en las filas restantes
            foreach (string[] fila in filas.Skip(1))
            {
                Console.Write(espacios + "║ ");
                Console.Write(fila[0] + new string(' ', biggest0Word.Length - fila[0].Length));
                Console.Write(" ║ ");
                Console.Write(fila[1] + new string(' ', biggest1Word.Length - fila[1].Length));
                Console.WriteLine(" ║");
            }


            Console.Write(espacios + '╚' + new string('═', biggest0Word.Length + 2) + "╩");
            Console.Write(new string('═', biggest1Word.Length + 2) + '╝');
            Console.WriteLine();

        }

        public static void ImprimirTextoCentrado(string texto, bool? write = true)
        {
            string espacios = new string(' ', (int)(Console.WindowWidth / 2.37));
            if ((bool)write)
            {
                Console.Write(espacios + texto);
            } else
            {
                Console.WriteLine(espacios + texto);
            }
        }
        public static void Menu()
        {
            Console.Clear();

            string[][] filas = {
                new string[] {"Boton", "Accion" },
                new string[] {"1", "Empezar juego" },
                new string[] {"2", "Agregar palabra" },
            };
            ImprimirTabla(filas);
            Console.WriteLine();
            ImprimirTextoCentrado("Eliga una opcion: ");


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
            AhorcadoController.ahorcado = new Personaje();
            PalabraController.palabra = PalabraController.Seleccionar();
            AhorcadoController.Espacios = Enumerable.Repeat("_", PalabraController.palabra.Length).ToArray();
        }

        static void Main(string[] args)
        {

            Menu();
        }


    }
}

