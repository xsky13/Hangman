using Hangman.Controladores;

namespace Hangman
{
    internal class Program
    {

        static void CorrerJuego()
        {
            AhorcadoController.Dibujar();
            AhorcadoController.ImprimirEpacios([-1]);
            AhorcadoController.Ingresar();
        }

        public static void Menu()
        {
            Console.Clear();
            Console.Write("Entre una opcion: ");

<<<<<<< HEAD

        }
        
    }

}

            while (true)
            {
                Console.Clear();
                Console.WriteLine(DibujarAhorcado());
                Console.WriteLine($"Partes del cuerpo dibujadas: {cuerpo}");
                Console.Write($"Ingrese 'a' para dibujar una parte, 'r' para deshacer una parte o 'q' para salir : ");
                string entrada = Console.ReadLine().ToLower();
=======

            Console.WriteLine("1 - Empezar juego");
=======
            Console.WriteLine("\n\n1 - Empezar juego");
>>>>>>> 587589111710e51039c20b28bbf6ccdf643ab32a
            Console.WriteLine("2 - Agregar palabra");
            Console.WriteLine("3 - Salir");

<<<<<<< HEAD
            Console.Write("\n\nEntre una opcion: ");
            int opcion = int.Parse(Console.ReadLine());
>>>>>>> 44e1e4245351d244d98c1f6f30f75fe86d22e461
=======

            int opcion;
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("\nIngrese un numero valido por favor");
                Console.WriteLine("Toque cualquier tecla para continuar...");
                Console.ReadKey();
                Menu();
            }
>>>>>>> 587589111710e51039c20b28bbf6ccdf643ab32a

            switch (opcion)
            {
                case 1:
                    {

                        PalabraController.palabra = PalabraController.Seleccionar();
                        CorrerJuego();
                        break;
                    }
                case 2:
                    {
                        PalabraController.Agregar();
                        break;
                    }
                case 3: return;
                default: Menu(); break;

            }
        }
        
        static void Main(string[] args)
        {

            Menu();
        }


<<<<<<< HEAD
                string[] dibujo = {
                    "  _______  ",
                    " |/     |   ",
                    $" |      {cabeza} ",
                    $" |     {brazoIzquierdo}{torso}{brazoDerecho} ",
                    $" |     {piernaIzquierda} {piernaDerecha}",
                    " |          ",
                    "_|___       "
                };
                return string.Join("\n", dibujo);
            }

        }
    }
}


=======
    }
}

>>>>>>> 44e1e4245351d244d98c1f6f30f75fe86d22e461
