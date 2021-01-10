using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionsExercise
{
    class CheckCharacter
    {
        public static void CheckCharacterIsAnAlphabet()
        {
            //The content of the exercise:
            //check whether a character is alphabet or not.


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("TASK NUMBER 3 \n");
            Console.ResetColor();

        ParameterizedThreadStart3:
            Console.WriteLine("Enter a key to check if it is a letter of the alphabet");
            char isItAlphabet = char.Parse(Console.ReadLine());

            if ((isItAlphabet >= 'a' && isItAlphabet <='z') || (isItAlphabet >= 'A' && isItAlphabet <= 'Z'))
            {
                Console.WriteLine($"The entered character: '{isItAlphabet}' is an alphabet");
            }
            else
            {
                Console.WriteLine($"The entered character: '{isItAlphabet}' is NOT an alphabet");
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nDo you want to check anather key?");
            Console.WriteLine("Press Y - YES or N - NO");
            Console.ResetColor();
            ConsoleKeyInfo keyPressed = Console.ReadKey();
            if (keyPressed.Key == ConsoleKey.Y)
            {
                Console.WriteLine();
                Console.WriteLine();
                goto ParameterizedThreadStart3;
            }
            else if (keyPressed.Key == ConsoleKey.N)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nEND OF TASK 3.\nPress any key to back main menu.");
                Console.ResetColor();
                Console.ReadKey();
                ShowMenu.ShowAllMenu();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nIncorrect value - END OF TASK 3.\nPress any key to back main menu.");
                Console.ResetColor();
                Console.ReadKey();
                ShowMenu.ShowAllMenu();
            }
        }
    }
}
