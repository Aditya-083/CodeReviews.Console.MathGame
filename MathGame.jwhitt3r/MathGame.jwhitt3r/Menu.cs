﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.jwhitt3r
{
    static class Menu
    {

        public static char GenerateMenu()
        {
            Console.WriteLine(@" Game Menu
                A) Addition
                B) Subtraction
                C) Division
                D) Multiplication
                E) List previous games
                P) Print Menu
                Q) Exit
            ");
            return GetUserInput();
        }

        public static char GenerateDifficultyMenu()
        {
            Console.WriteLine(@" Difficulty Menu
                A) Difficulty Level 1
                B) Difficulty Level 2
                C) Difficulty Level 3
            ");
            return GetUserInput();
        }

        public static char GetUserInput()
        {
            string userInput = Console.ReadLine();

            switch(userInput.Trim().ToLower())
            {
                case "a":
                    Console.WriteLine("A");
                    return '+';
                case "b":
                    Console.WriteLine("B");
                    return '-';
                case "c":
                    Console.WriteLine("C");
                    return '/';
                case "d":
                    Console.WriteLine("D");
                    return '*';
                case "e":
                    Console.WriteLine("E");
                    return 'e';
                case "f":
                    Console.WriteLine("F");
                    return 'f';
                case "g":
                    Console.WriteLine("G");
                    return 'g';
                case "q":
                    Console.WriteLine("Q");
                    return 'q';
                default:
                    Console.WriteLine("Default");
                    return '+';
            }
        }
    }
}
