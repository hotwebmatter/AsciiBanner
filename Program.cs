using System;
using static System.Console;

namespace AsciiBanner
{
    class Program
    {
        static void RepeatChar(string character, int reps)
        {
            for (int i = 0; i < reps; i++)
            {
                Write(character);
            }
        }
        static void Main(string[] args)
        {
            // variable declaration
            const int bannerWidth = 54;
            const string name = "Matthew Obert";
            string date = DateTime.Now.ToString("MMMM dd");
            string assignment;
            string purpose;

            // variable assignment
            WriteLine("What is the assignment number?");
            assignment = ReadLine();
            WriteLine("What is the purpose of this assignment?");
            purpose = ReadLine();

            // output
            RepeatChar("#", bannerWidth);
            WriteLine();

            Write("# Programming Assignment #{0}", assignment);
            RepeatChar(" ", 27 - assignment.Length);
            WriteLine("#");

            Write("# Developer: {0}", name);
            RepeatChar(" ", 40 - name.Length);
            WriteLine("#");

            Write("# Date Submitted: {0} #", date);
            RepeatChar(" ", 40 - date.Length);
            WriteLine("#");

            Write("# Purpose: {0} #", purpose);
            RepeatChar(" ", 40 - purpose.Length);
            WriteLine("#");

            RepeatChar("#", 54);

        }
    }
}
