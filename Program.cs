/**
 * ######################################################
 * ##    Programming Assignment #2                     ##
 * ##    Developer: Matthew Obert                      ##
 * ##    Date Submitted: September 01 2019             ##
 * ##    Purpose: Provide internal documentation.      ##
 * ######################################################
 */

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
            string date = DateTime.Now.ToString("MMMM dd yyyy");
            string assignment;
            string purpose;

            // variable assignment
            WriteLine("What is the assignment number?");
            assignment = ReadLine();
            WriteLine("What is the purpose of this assignment?");
            purpose = ReadLine();

            // output
            Write("/**\n * ");
            RepeatChar("#", bannerWidth);
            WriteLine();

            /*
             * TODO: refactor to use bannerWidth to calculate spacing
             *       instead of relying on hard-coded "magic numbers"
             */

            /*
             * TODO: if purpose.Length exceeds space available, either
             *       ask for a shorter "purpose" string, or create an
             *       algorithm to break purpose across multiple lines
             */

            Write(" * ##    Programming Assignment #{0}", assignment);
            RepeatChar(" ", 22 - assignment.Length);
            WriteLine("##");

            Write(" * ##    Developer: {0}", name);
            RepeatChar(" ", 35 - name.Length);
            WriteLine("##");

            Write(" * ##    Date Submitted: {0}", date);
            RepeatChar(" ", 30 - date.Length);
            WriteLine("##");

            Write(" * ##    Purpose: {0}", purpose);
            RepeatChar(" ", 37 - purpose.Length);
            WriteLine("##");

            Write(" * ");
            RepeatChar("#", bannerWidth);
            WriteLine();
            WriteLine(" */");
        }
    }
}
