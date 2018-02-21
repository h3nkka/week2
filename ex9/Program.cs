using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hangman: Guess my word by inputting letters one by one!\nYou've got 5 chances to guess correctly!");
                List<char> word = new List<char> { 'S', 'A', 'Y', 'O', 'R', 'I' };
                List<char> revealedWord = new List<char> { '_', '_', '_', '_', '_', '_' };
                List<char> guessedLetters = new List<char>();
                int chances = 5;
                char guess;

                while (true)
                {
                    Console.WriteLine();
                    revealedWord.ForEach(x => Console.Write(x));
                    Console.WriteLine("\nGuess a letter. {0} chances remain.", chances);
                    if (char.TryParse(Console.ReadLine().ToUpper(), out guess))
                    {
                        if (!guessedLetters.Contains(guess))
                            guessedLetters.Add(guess);
                        else
                        {
                            Console.WriteLine("You already tried that letter.");
                            continue;
                        }

                        if (word.Contains(guess))
                        {
                            var indexes = word.Select((value, index) => new { value, index }) //getting indices where guessed character occurs
                                .Where(x => x.value == guess)
                                .Select(x => x.index)
                                .ToList();
                            for (int i = 0; i < indexes.Count; i++)
                            {
                                revealedWord[indexes[i]] = guess; //setting guessed character(s) to respective word's indices                               
                            }
                            if (!revealedWord.Contains('_'))
                            {
                                revealedWord.ForEach(x => Console.Write(x));
                                Console.WriteLine("\nYou guessed the word! You win!");
                                break;
                            }
                        }
                        else if (chances > 1)
                        {
                            Console.WriteLine("No letter {0} in the word. Try again!", guess, chances);
                            chances--;
                        }
                        else
                        {
                            Console.WriteLine("No letter {0} in the word. You have 0 chances left.\nGame over, better luck next time!", guess);
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error: Incorrect input! Input only a single character.");
                    }
                }

                Console.ReadKey(true);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
