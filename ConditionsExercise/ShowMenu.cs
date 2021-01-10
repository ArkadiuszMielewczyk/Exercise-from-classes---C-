using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionsExercise
{
    class ShowMenu
    {
        public static void ShowAllMenu()
        {
            Console.Clear();
            string[] MenuItem =
            {
                "      TASK 1  -  Find maximum between three numbers.",
                "      TASK 2  -  Check whether a number is divisible by 5 and 11 or not.",
                "      TASK 3  -  Check whether a character is alphabet or not..",
                "      TASK 4  -  Input any alphabet and check whether it is vowel or consonant.",
                "      TASK 5  -  Input month number and print number of days in that month.",
                "      TASK 6  -  Find all roots of a quadratic equation (ax^2 + bx + c = 0)",
                "      TASK 7  -  Input electricity units used and calculate total electricity bill:",
                "      PRESS 8 -  EXIT"
            };

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Select the appropriate item:");
            Console.ResetColor();

            for (int i = 0; i < MenuItem.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"{MenuItem[i]}", 40);
            }

            ConsoleKeyInfo keyPressed = Console.ReadKey();
            if (keyPressed.Key == ConsoleKey.D1)
            {
                Console.Clear(); CheckTheBiggest.WhichOneIsTheBiggest();
            }
            else if (keyPressed.Key == ConsoleKey.D2)
            {
                Console.Clear(); CheckDivisible.CheckDivisibleNumber();
            }
            else if (keyPressed.Key == ConsoleKey.D3)
            {
                Console.Clear(); CheckCharacter.CheckCharacterIsAnAlphabet();
            }
            else if (keyPressed.Key == ConsoleKey.D4)
            {
                Console.Clear(); CheckVowelOrConsonant.CheckAlphabetIsVowelOrConsonant();
            }
            else if (keyPressed.Key == ConsoleKey.D5)
            {
                Console.Clear(); CheckNumberOfDaysInMoths.NumberOfDaysInMoths();
            }
            else if (keyPressed.Key == ConsoleKey.D6)
            {
                Console.Clear(); FindAllRoots.FindAllRootsOfQuadraticEquation();
            }
            else if (keyPressed.Key == ConsoleKey.D7)
            {
                Console.Clear(); CalculateElectricity.CalculateUsedElectricityUnit();
            }
            else if (keyPressed.Key == ConsoleKey.D7)
            {
                Environment.Exit(0);
            }

        }



    }
}
