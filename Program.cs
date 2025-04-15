namespace Hangman
{
    internal class Program
    {
        static int cuerpo = 0; // Variable para controlar las partes del cuerpo
        
        static void Main(string[] args)
        {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD

        }
        static void PlayGame()
        {
            string[] words = { "apple", "banana", "cherry" };
            Random random = new Random();
            string wordToGuess = words[random.Next(words.Length)];
            string guessedWord = new string('_', wordToGuess.Length);
            int attemptsLeft = 6;
            while (attemptsLeft > 0 && guessedWord != wordToGuess)
            {
                Console.WriteLine($"Word to guess: {guessedWord}");
                Console.WriteLine($"Attempts left: {attemptsLeft}");
                Console.Write("Enter a letter: ");
                char guessedLetter = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (wordToGuess.Contains(guessedLetter))
                {
                    for (int i = 0; i < wordToGuess.Length; i++)
                    {
                        if (wordToGuess[i] == guessedLetter)
                        {
                            guessedWord = guessedWord.Remove(i, 1).Insert(i, guessedLetter.ToString());
                        }
                    }
                }
                else
                {
                    attemptsLeft--;
                    Console.WriteLine($"Wrong guess! '{guessedLetter}' is not in the word.");
                }
            }
            if (guessedWord == wordToGuess)
            {
                Console.WriteLine($"Congratulations! You've guessed the word: {wordToGuess}");
            }
            else
            {
                Console.WriteLine($"Game over! The word was: {wordToGuess}");
            }
=======
            Console.WriteLine("Hello, World! jared");
>>>>>>> a0965f047fd53445e4fa3e428fbf9af56c31b28b
        }
    }

}
=======
=======
>>>>>>> 466c8c7fb4c8cc1212aa523cd2688567ef907996
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
<<<<<<< HEAD
>>>>>>> 46dec88a763fdbc4724ec23ab3a7f736d35019fd
=======
=======

        }
        static void PlayGame()
        {
            string[] words = { "apple", "banana", "cherry" };
            Random random = new Random();
            string wordToGuess = words[random.Next(words.Length)];
            string guessedWord = new string('_', wordToGuess.Length);
            int attemptsLeft = 6;
            while (attemptsLeft > 0 && guessedWord != wordToGuess)
            {
                Console.WriteLine($"Word to guess: {guessedWord}");
                Console.WriteLine($"Attempts left: {attemptsLeft}");
                Console.Write("Enter a letter: ");
                char guessedLetter = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (wordToGuess.Contains(guessedLetter))
                {
                    for (int i = 0; i < wordToGuess.Length; i++)
                    {
                        if (wordToGuess[i] == guessedLetter)
                        {
                            guessedWord = guessedWord.Remove(i, 1).Insert(i, guessedLetter.ToString());
                        }
                    }
                }
                else
                {
                    attemptsLeft--;
                    Console.WriteLine($"Wrong guess! '{guessedLetter}' is not in the word.");
                }
            }
            if (guessedWord == wordToGuess)
            {
                Console.WriteLine($"Congratulations! You've guessed the word: {wordToGuess}");
            }
            else
            {
                Console.WriteLine($"Game over! The word was: {wordToGuess}");
            }
=======
            Console.WriteLine("Hello, World! jared");
>>>>>>> a0965f047fd53445e4fa3e428fbf9af56c31b28b
        }
    }

}
>>>>>>> 62a325fb6cc4d1ccc5e173088457c94e3e0c8ff3
>>>>>>> 466c8c7fb4c8cc1212aa523cd2688567ef907996
