using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionsExercise
{
    class CheckNumberOfDaysInMoths
    {
        public static void NumberOfDaysInMoths()
        {
            //The content of the exercise:
            //input month number and print number of days in that month.


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("TASK NUMBER 5 \n");
            Console.ResetColor();

        ParameterizedThreadStart5:
            int numberOfMonth, chosenYear;
            Console.WriteLine("Write the month number (e.g. January - 1; February - 2; etc.)");
            int.TryParse(Console.ReadLine(), out numberOfMonth);
            Console.WriteLine("Write in which year you want to check the number of days in the given month.");
            int.TryParse(Console.ReadLine(), out chosenYear);
            if (numberOfMonth > 0 && numberOfMonth <= 12)
            {
                int numberDayInMonth = System.DateTime.DaysInMonth(chosenYear, numberOfMonth);
                string nameOfMonth = null;
                if (numberOfMonth == 1)
                {
                    nameOfMonth = "January";
                }
                else if (numberOfMonth == 2)
                {
                    nameOfMonth = "February";
                }
                else if (numberOfMonth == 3)
                {
                    nameOfMonth = "March";
                }
                else if (numberOfMonth == 4)
                {
                    nameOfMonth = "Aprin";
                }
                else if (numberOfMonth == 5)
                {
                    nameOfMonth = "May";
                }
                else if (numberOfMonth == 6)
                {
                    nameOfMonth = "June";
                }
                else if (numberOfMonth == 7)
                {
                    nameOfMonth = "July";
                }
                else if (numberOfMonth == 8)
                {
                    nameOfMonth = "August";
                }
                else if (numberOfMonth == 9)
                {
                    nameOfMonth = "September";
                }
                else if (numberOfMonth == 10)
                {
                    nameOfMonth = "October";
                }
                else if (numberOfMonth == 11)
                {
                    nameOfMonth = "November";
                }
                else if (numberOfMonth == 12)
                {
                    nameOfMonth = "December";
                }

                Console.WriteLine($"\nThere are: {numberDayInMonth} days in {nameOfMonth} in {chosenYear}.");
            }
            else
            {
                Console.WriteLine("Incorrect month number, please enter the month number again.\n");
                goto ParameterizedThreadStart5;
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nDo you want to check a different number of days in another month?");
            Console.WriteLine("Press Y - YES or N - NO");
            Console.ResetColor();
            ConsoleKeyInfo keyPressed = Console.ReadKey();
            if (keyPressed.Key == ConsoleKey.Y)
            {
                Console.WriteLine();
                Console.WriteLine();
                goto ParameterizedThreadStart5;
            }
            else if (keyPressed.Key == ConsoleKey.N)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nEND OF TASK 5.\nPress any key to back main menu.");
                Console.ResetColor();
                Console.ReadKey();
                ShowMenu.ShowAllMenu();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nIncorrect value - END OF TASK 5.\nPress any key to back main menu.");
                Console.ResetColor();
                Console.ReadKey();
                ShowMenu.ShowAllMenu();
            }
        }
    }
}
