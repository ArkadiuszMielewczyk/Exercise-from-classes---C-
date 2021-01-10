using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionsExercise
{
    class CheckDivisible
    {
        public static void CheckDivisibleNumber()
        {
            //The content of the exercise:
            //check whether a number is divisible by 5 and 11 or not.


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("TASK NUMBER 2 \n");
            Console.ResetColor();

        ParameterizedThreadStart2:
            int numberToCheck;
            Console.WriteLine("Enter an integer to find out if it is divisible by 5 and 11.");
            int.TryParse(Console.ReadLine(), out numberToCheck);

            if ((numberToCheck % 5 == 0) && (numberToCheck % 11 == 0))
            {
                Console.WriteLine($"The number: '{numberToCheck}' is divisible by 5 and 11");
            }
            else
            {
                Console.WriteLine($"The number: '{numberToCheck}' isn't divisible by 5 and 11.");
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nDo you want to check anather number?");
            Console.WriteLine("Press Y - YES or N - NO");
            Console.ResetColor();
            ConsoleKeyInfo keyPressed = Console.ReadKey();
            if (keyPressed.Key == ConsoleKey.Y)
            {
                Console.WriteLine();
                Console.WriteLine();
                goto ParameterizedThreadStart2;
            }
            else if (keyPressed.Key == ConsoleKey.N)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nEND OF TASK 2.\nPress any key to back main menu.");
                Console.ResetColor();
                Console.ReadKey();
                ShowMenu.ShowAllMenu();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nIncorrect value - END OF TASK 2.\nPress any key to back main menu.");
                Console.ResetColor();
                Console.ReadKey();
                ShowMenu.ShowAllMenu();
            }
        }
    }
}
