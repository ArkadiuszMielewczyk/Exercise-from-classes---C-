using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionsExercise
{
    class CheckTheBiggest
    {
        public static void WhichOneIsTheBiggest()
        {
            //The content of the exercise:
            //find maximum between three numbers.


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("TASK NUMBER 1 \n");
            Console.ResetColor();

        ParameterizedThreadStart1:
            int firstNumber, secundNumber, thirdNumber;
            Console.WriteLine("Enter first number");
            int.TryParse(Console.ReadLine(), out firstNumber);
            Console.WriteLine("Enter secund number");
            int.TryParse(Console.ReadLine(), out secundNumber);
            Console.WriteLine("Enter first number");
            int.TryParse(Console.ReadLine(), out thirdNumber);

            int biggestNumber = firstNumber;
            if (secundNumber > biggestNumber)
            {
                biggestNumber = secundNumber;
            }
            if (thirdNumber > biggestNumber)
            {
                biggestNumber = thirdNumber;
            }
            Console.WriteLine();
            Console.WriteLine($"The biggest number is: {biggestNumber}");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nDo you want to check anather collection of numbers?");
            Console.WriteLine("Press Y - YES or N - NO");
            Console.ResetColor();
            ConsoleKeyInfo keyPressed = Console.ReadKey();
            if (keyPressed.Key == ConsoleKey.Y)
            {
                Console.WriteLine();
                Console.WriteLine();
                goto ParameterizedThreadStart1;
            }
            else if (keyPressed.Key == ConsoleKey.N)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nEND OF TASK 1.\nPress any key to back main menu.");
                Console.ResetColor();
                Console.ReadKey();
                ShowMenu.ShowAllMenu();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nIncorrect value - END OF TASK 1.\nPress any key to back main menu.");
                Console.ResetColor();
                Console.ReadKey();
                ShowMenu.ShowAllMenu();
            }



        }


    }
}
