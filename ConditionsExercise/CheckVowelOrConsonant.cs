using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionsExercise
{
    class CheckVowelOrConsonant
    {
        public static void CheckAlphabetIsVowelOrConsonant()
        {
            //The content of the exercise:
            //input any alphabet and check whether it is vowel or consonant.


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("TASK NUMBER 4 \n");
            Console.ResetColor();

        ParameterizedThreadStart4:
            Console.WriteLine("Input any alphabet and check whether it is vowel or consonant.");
            char letterToCheck = char.Parse(Console.ReadLine());
            if (letterToCheck == 'a' || letterToCheck == 'e' || letterToCheck == 'i' || letterToCheck == 'o' || letterToCheck == 'u')
            {
                Console.WriteLine($"The input letter: '{letterToCheck}' is a lowercase vowel.");
            }
            else if (letterToCheck == 'A' || letterToCheck == 'E' || letterToCheck == 'I' || letterToCheck == 'O' || letterToCheck == 'U')
            {
                Console.WriteLine($"The input letter: '{letterToCheck}' is an uppercase vowel.");
            }
            else
            {
                Console.WriteLine($"The input letter: '{letterToCheck}' is a consonant.");
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nDo you want to check anather letter?");
            Console.WriteLine("Press Y - YES or N - NO");
            Console.ResetColor();
            ConsoleKeyInfo keyPressed = Console.ReadKey();
            if (keyPressed.Key == ConsoleKey.Y)
            {
                Console.WriteLine();
                Console.WriteLine();
                goto ParameterizedThreadStart4;
            }
            else if(keyPressed.Key == ConsoleKey.N)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nEND OF TASK 4.\nPress any key to back main menu.");
                Console.ResetColor();
                Console.ReadKey();
                ShowMenu.ShowAllMenu();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nIncorrect value - END OF TASK 4.\nPress any key to back main menu.");
                Console.ResetColor();
                Console.ReadKey();
                ShowMenu.ShowAllMenu();
            }
        }
    }
}
