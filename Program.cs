using Hangman.Controladores;

namespace Hangman
{
    internal class Program
    {

        static void CorrerJuego()
        {
            AhorcadoController.Dibujar();
            AhorcadoController.ImprimirEpacios([ -1], "a");
            AhorcadoController.Ingresar();
        }
        
        static void Main(string[] args)
        {


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
            Console.WriteLine("2 - Agregar palabra");

            Console.Write("\n\nEntre una opcion: ");
            int opcion = int.Parse(Console.ReadLine());
>>>>>>> 44e1e4245351d244d98c1f6f30f75fe86d22e461

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
            
            }
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
