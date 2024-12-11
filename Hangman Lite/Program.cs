namespace Hangman_Lite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secretWord, displayWord, letterGuess, unguessedLetters;
            int incorrectGuesses, letterIndex;
            bool done;

            List<string> guessedLetters = new List<string>();

            List<string> secretWords = new List<string>() {"COMPUTER", "TABLE", "TRIANGLE", "SQUARE", "TREE", "MOON", "LENGTH", "SCHOOL", "UNIVERSITY", "COLLEGE", "TRUMPET", "MUSIC"};

            Random generator = new Random();

            incorrectGuesses = 0;
            done = false;

            secretWord = secretWords[generator.Next(secretWords.Count)];
            unguessedLetters = secretWord;
            displayWord = "";
            for (int i = 0; i < secretWord.Length; i++)
            {
                displayWord = displayWord + "_";
            }

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
                else if (incorrectGuesses == 4)
                {
                    DrawHangmanGuessFour();
                }
                else if (incorrectGuesses == 5)
                {
                    DrawHangmanGuessFive();
                }
                else if (incorrectGuesses == 6)
                {
                    DrawHangmanGuessSix();
                }

                Console.WriteLine();

                Console.WriteLine(displayWord);

                Console.WriteLine();

                Console.Write("You have " + (6 - incorrectGuesses) + " incorrect guesses left! The letters you have already guessed are: ");
                foreach (string letter in guessedLetters)
                {
                    Console.Write(letter + ", ");
                }

                Console.WriteLine();
                Console.WriteLine();

                Console.Write("Guess a letter: ");
                letterGuess = Console.ReadLine();

                Console.WriteLine();

                for (int i = 0; i < guessedLetters.Count; i++)
                {
                    if (letterGuess.ToUpper() == guessedLetters[i])
                    {
                        Console.Write("You can't guess a letter you have already guessed, please guess another letter: ");
                        letterGuess = Console.ReadLine();
                        i = -1;

                        Console.WriteLine();
                    }
                }

                while (letterGuess.Length != 1)
                {
                    Console.Write("That is not a single letter, please enter just one letter: ");
                    letterGuess = Console.ReadLine();

                    Console.WriteLine();

                    for (int i = 0; i < guessedLetters.Count; i++)
                    {
                        if (letterGuess.ToUpper() == guessedLetters[i])
                        {
                            Console.Write("You can't guess a letter you have already guessed, please guess another letter: ");
                            letterGuess = Console.ReadLine();
                            i = -1;

                            Console.WriteLine();
                        }
                    }
                }

                letterGuess = letterGuess.ToUpper();

                guessedLetters.Add(letterGuess);

                if (secretWord.Contains(letterGuess))
                {
                    Console.WriteLine("Correct guess!");

                    while (unguessedLetters.Contains(letterGuess))
                    {
                        letterIndex = unguessedLetters.IndexOf(letterGuess);
                        unguessedLetters = unguessedLetters.Remove(letterIndex, 1);
                        unguessedLetters = unguessedLetters.Insert(letterIndex, "_");

                        displayWord = displayWord.Remove(letterIndex, 1);
                        displayWord = displayWord.Insert(letterIndex, letterGuess);
                    }
                }
                else if (!secretWord.Contains(letterGuess))
                {
                    Console.WriteLine("Incorrect guess...");
                    incorrectGuesses += 1;
                }

                Thread.Sleep(500);

                Console.Clear();

                if (displayWord == secretWord)
                {
                    Console.WriteLine("Congratulations, you have guessed the word before you ran out of incorrect guesses!");
                    done = true;

                    Console.WriteLine();

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
                    else if (incorrectGuesses == 4)
                    {
                        DrawHangmanGuessFour();
                    }
                    else if (incorrectGuesses == 5)
                    {
                        DrawHangmanGuessFive();
                    }
                    else if (incorrectGuesses == 6)
                    {
                        DrawHangmanGuessSix();
                    }

                    Console.WriteLine();

                    Console.WriteLine(displayWord);
                }
                else if (incorrectGuesses == 6)
                {
                    Console.WriteLine("You ran out of incorrect guesses before guessing the word... The word was " + secretWord + ".");
                    done = true;

                    DrawHangmanGuessThree();

                    Console.WriteLine();

                    Console.WriteLine(displayWord);
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
            Console.WriteLine("  |   |");
            Console.WriteLine("      |");
            Console.WriteLine("      |");
            Console.WriteLine("=========");
        }

        static void DrawHangmanGuessThree()
        {
            Console.WriteLine("  +---+");
            Console.WriteLine("  |   |");
            Console.WriteLine("  O   |");
            Console.WriteLine(" /|   |");
            Console.WriteLine("      |");
            Console.WriteLine("      |");
            Console.WriteLine("=========");
        }

        static void DrawHangmanGuessFour()
        {
            Console.WriteLine("  +---+");
            Console.WriteLine("  |   |");
            Console.WriteLine("  O   |");
            Console.WriteLine(" /|\\  |");
            Console.WriteLine("      |");
            Console.WriteLine("      |");
            Console.WriteLine("=========");
        }

        static void DrawHangmanGuessFive()
        {
            Console.WriteLine("  +---+");
            Console.WriteLine("  |   |");
            Console.WriteLine("  O   |");
            Console.WriteLine(" /|\\  |");
            Console.WriteLine(" /    |");
            Console.WriteLine("      |");
            Console.WriteLine("=========");
        }

        static void DrawHangmanGuessSix()
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
