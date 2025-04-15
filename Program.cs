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

            Console.WriteLine("1 - Empezar juego");
            Console.WriteLine("2 - Agregar palabra");

            Console.Write("\n\nEntre una opcion: ");
            int opcion = int.Parse(Console.ReadLine());

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


    }
}

