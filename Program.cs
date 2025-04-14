namespace Hangman
{
    internal class Program
    {
        static int cuerpo = 0; // Variable para controlar las partes del cuerpo

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(DibujarAhorcado());
                Console.WriteLine($"Partes del cuerpo dibujadas: {cuerpo}");
                Console.Write("Ingrese 'a' para dibujar una parte, 'r' para deshacer una parte o 'q' para salir: ");
                string entrada = Console.ReadLine().ToLower();

                if (entrada == "a")
                {
                    if (cuerpo < 6) // Máximo 6 partes del cuerpo (cabeza, torso, brazos, piernas)
                    {
                        cuerpo++;
                    }
                }
                else if (entrada == "s")
                {
                    if (cuerpo > 0)
                    {
                        cuerpo--;
                    }
                }
                else if (entrada == "q")
                {
                    Console.WriteLine("Saliendo del programa.");
                    break;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese 'a', 'r' o 'q'.");
                }
            }
        }

        static string DibujarAhorcado()
        {
            string[] dibujo = {
                "  _______  ",
                " |/      |  ",
                " |      " + (cuerpo > 0 ? " O" : " "),       // Cabeza (1)
                " |     " + (cuerpo > 2 ? " /|\\" : (cuerpo > 1 ? " /|" : "   ")), // Torso y Brazos (2, 3)
                " |      " + (cuerpo > 4 ? "/ \\" : (cuerpo > 3 ? "/ " : "   ")), // Piernas (4, 5)
                " |           ",
                "_|___        "
            };
            if (cuerpo > 5) { Console.WriteLine(".\r\n..........._____\r\n..../ ../ ....+ ....\\\r\n...| ..| ....RIP ...|\r\n...| ..| ........... |\r\n...|.. | ............|\r\n\\ .| ..|.. ./\\/\\//\\ .|/ "); }
            return string.Join("\n", dibujo);
        }
    }
}