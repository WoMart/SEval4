using System;
using TestingGrounds.SEADM.Models;

namespace TestingGrounds
{
    class Program
    {
        static void Main(string[] args)
        {
            SeadmAutomat fsa = new();

            string allowed = "ynbqr";
            char input = '\0';
            while (true)
            {
                Console.WriteLine(fsa.GetQuestion());

                do
                {
                    Console.Write($"[{allowed}] >>> ");
                    input = Console.ReadKey(false).KeyChar;
                    Console.WriteLine();
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
                        return;
                }

                Console.Clear();
            }
        }
    }
}
