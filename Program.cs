namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
