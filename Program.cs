namespace Hangman
{
    internal class Program
    {
        static int cuerpo = 0; // Variable para controlar las partes del cuerpo
        
        static void Main(string[] args)
        {
<<<<<<< HEAD
            while (true)
            {
                Console.Clear();
                Console.WriteLine(DibujarAhorcado());
                Console.WriteLine($"Partes del cuerpo dibujadas: {cuerpo}");
                Console.Write($"Ingrese 'a' para dibujar una parte, 'r' para deshacer una parte o 'q' para salir : ");
                string entrada = Console.ReadLine().ToLower();

                if (entrada == "a")
                {
                    if (cuerpo < 7)
                    {
                        cuerpo++;
                    }
                    else
                    {
                        Console.WriteLine("No se pueden agregar más partes del cuerpo.");
                        Console.ReadKey();
                    }
                }
                else if (entrada == "r")
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
                    Console.ReadKey();
                }
            }
        }

        static string DibujarAhorcado()
        {
            if (cuerpo > 6)
            {
                Console.WriteLine(".\r\n..........._____\r\n..../ ../ ....+ ....\\\r\n...| ..| ....RIP ...|\r\n...| ..| ........... |\r\n...|.. | ............|\r\n\\ .| ..|.. ./\\/\\//\\ .|/ ");
                return "";
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
                return string.Join("\n", dibujo);
            }
=======
<<<<<<< HEAD
            Console.WriteLine("Hello, pussy.");
=======
            Console.WriteLine("Hello, World! jared");
>>>>>>> c38bd599831da85be8139fd6d012b69eb8eecfec
>>>>>>> ef6ed6c4377fb92ff92e3bea860a992fd8e8ff2b
        }
    }
}