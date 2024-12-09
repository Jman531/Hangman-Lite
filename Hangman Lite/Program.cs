namespace Hangman_Lite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secretWord, displayWord, letterGuess;
            int incorrectGuesses;
            bool done;

            List<string> guessedLetters = new List<string>();

            secretWord = "COMPUTER";
            displayWord = "________";
            incorrectGuesses = 0;
            done = false;

            while (!done)
            {
                if (incorrectGuesses == 0)
                {
                    DrawHangmanGuessZero();
                }
                else if (incorrectGuesses == 1)
                {
                    DrawHangmanGuessOne();
                }
                else if (incorrectGuesses == 2)
                {
                    DrawHangmanGuessTwo();
                }
                else if (incorrectGuesses == 3)
                {
                    DrawHangmanGuessThree();
                }

                Console.WriteLine();

                Console.WriteLine(displayWord);

                Console.WriteLine();

                Console.Write("You have " + (3 - incorrectGuesses) + " guesses left! The letters you have already guessed are: ");
                foreach (string letter in guessedLetters)
                {
                    Console.Write(letter + ", ");
                }

                Console.WriteLine();
                Console.WriteLine();

                Console.Write("Guess a letter: ");
                letterGuess = Console.ReadLine();

                while (letterGuess.Length != 1)
                {
                    Console.WriteLine();

                    Console.Write("That is not a single letter, please enter just one letter: ");
                    letterGuess = Console.ReadLine();
                }
                
                if (secretWord.Contains(letterGuess.ToUpper()))
                {
                    Console.WriteLine("Correct guess!");
                }
                else if (!secretWord.Contains(letterGuess.ToUpper()))
                {
                    Console.WriteLine("Incorrect guess...");
                    incorrectGuesses += 1;
                }
            }
        }

        static void DrawHangmanGuessZero()
        {
            Console.WriteLine("  +---+");
            Console.WriteLine("  |   |");
            Console.WriteLine("      |");
            Console.WriteLine("      |");
            Console.WriteLine("      |");
            Console.WriteLine("      |");
            Console.WriteLine("=========");
        }

        static void DrawHangmanGuessOne()
        {
            Console.WriteLine("  +---+");
            Console.WriteLine("  |   |");
            Console.WriteLine("  O   |");
            Console.WriteLine("      |");
            Console.WriteLine("      |");
            Console.WriteLine("      |");
            Console.WriteLine("=========");
        }

        static void DrawHangmanGuessTwo()
        {
            Console.WriteLine("  +---+");
            Console.WriteLine("  |   |");
            Console.WriteLine("  O   |");
            Console.WriteLine(" /|\\  |");
            Console.WriteLine("      |");
            Console.WriteLine("      |");
            Console.WriteLine("=========");
        }

        static void DrawHangmanGuessThree()
        {
            Console.WriteLine("  +---+");
            Console.WriteLine("  |   |");
            Console.WriteLine("  O   |");
            Console.WriteLine(" /|\\  |");
            Console.WriteLine(" / \\  |");
            Console.WriteLine("      |");
            Console.WriteLine("=========");
        }
    }
}
