using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_Statistics_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grade Statistics Program.");

            string[] subjects = { "Mathematics", "Swedish", "English", "History", "Physics" };
            int[] scores = new int[5];
            char[] notes = new char[5];

            getScores(subjects, scores);
            convertScores(scores, notes);
            showAllScores(subjects, scores, notes);
            statistics(notes);
            totalScore(scores);

            Console.WriteLine("\nThank you for using the program.");
            Console.ReadLine();
        }

        static void getScores(string[] subjects, int[] scores)
        {
            Console.WriteLine();

            for (int i = 0; i < subjects.Length; i++)
            {
                while (true)
                {
                    Console.Write($"{subjects[i]} point?: ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out int number))
                    {
                        if (number >= 1 && number <= 100) // between 1-100?
                        {
                            scores[i] = number;
                            break; // If input is true, exit from loop.
                        }
                        else
                        {
                            Console.WriteLine("\nError! Enter a number between 1-100.\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nError! Please enter a valid number between 1-100.\n");
                    }
                }
            }
        }

        static void convertScores(int[] scores, char[] notes)
        {
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] < 50) notes[i] = 'F';
                else if (scores[i] >= 50 && scores[i] < 100) notes[i] = 'C';
                else notes[i] = 'A';
            }
        }

        static void showAllScores(string[] subjects, int[] scores, char[] notes)
        {
            Console.WriteLine();
            for (int i = 0; i < subjects.Length; i++)
            {
                Console.WriteLine($"{subjects[i]}: {scores[i]} -> {notes[i]}");
            }
        }

        static void statistics(char[] notes)
        {
            int totalA = 0;
            int totalC = 0;
            int totalF = 0;

            foreach (var note in notes)
            {
                if (note == 'A') totalA++;
                if (note == 'C') totalC++;
                if (note == 'F') totalF++;
            }
            Console.WriteLine($"\nA: {totalA}\nC: {totalC}\nF: {totalF}");
        }

        static void totalScore(int[] scores)
        {
            int allTotal = 0;

            foreach (var score in scores)
            {
                allTotal += score;
            }
            Console.WriteLine($"Total score: {allTotal}");
        }


    }
}
