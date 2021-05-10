using System;
using TestingGrounds.SEADM.Models;

namespace TestingGrounds
{
    class Program
    {
        static void Main(string[] args)
        {
            TestSeadmAutomata();
        }

        private static void TestSeadmAutomata()
        {
            SeadmAutomat fsa = new();

            string allowed = "ynbqr";
            ConsoleKeyInfo key;
            char input;
            while (true)
            {
                Console.WriteLine(fsa.GetQuestion());

                do
                {
                    Console.Write($"[{allowed}] >>> ");

                    // Allowing ReadKey to print the character
                    // results in corrupted Out buffer on next line.
                    // Therefore, skip Escape
                    key   = Console.ReadKey(true);
                    input = (key.Key == ConsoleKey.Escape)
                        ? '\0'
                        : key.KeyChar;

                    Console.WriteLine(input);
                } while (!allowed.Contains(input));

                switch (input)
                {
                    case 'y':
                        fsa.NextQuestion(true);
                        break;

                    case 'n':
                        fsa.NextQuestion(false);
                        break;

                    case 'b':
                        fsa.PreviousQuestion();
                        break;

                    case 'r':
                        fsa.Reset();
                        break;

                    case 'q':
                        Console.WriteLine("\nExiting the test...");
                        return;

                    default:
                        throw new Exception($"Recieved unexpected input: {input}.");
                }

                Console.Clear();
            }
        }
    }
}
