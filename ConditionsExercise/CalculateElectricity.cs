using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionsExercise
{
    class CalculateElectricity
    {
        public static void CalculateUsedElectricityUnit()
        {
            //The content of the exercise:
            //input electricity units used and calculate total electricity bill according to the given condition s:
            //    For first 50 units-- > PLN. 0.50 / unit
            //    For next 100 units-- > PLN. 0.75 / unit
            //    For next 200 units-- > PLN. 1.20 / unit
            //    For unit above 3 50-- > PLN 1.50 / unit
            //    An additional surcharge of 10 % is added to the bill


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("TASK NUMBER 7 \n");
            Console.ResetColor();

        ParameterizedThreadStart7:
            double numberOfUnits, priceForElectricity;
            double rateTo50 = 0.5;
            double rate50To150 = 0.75;
            double rate150To350 = 1.2;
            double rateFrom350 = 1.5;
            double additionalSurcharge = 1.1;

            Console.WriteLine("Enter the amount of units of electricity used:");
            double.TryParse(Console.ReadLine(), out numberOfUnits);

            if (numberOfUnits <= 50)
            {
                priceForElectricity = (numberOfUnits * rateTo50) * additionalSurcharge;
            }
            else if (numberOfUnits > 50 && numberOfUnits <= 150)
            {
                priceForElectricity = ((50 * rateTo50) + ((numberOfUnits - 50) * rate50To150)) * additionalSurcharge;
            }
            else if (numberOfUnits > 150 && numberOfUnits <= 350)
            {
                priceForElectricity = ((50 * rateTo50) + (100 * rate50To150) + ((numberOfUnits - 150) * rate150To350)) * additionalSurcharge;
            }
            else
            {
                priceForElectricity = ((50 * rateTo50) + (100 * rate50To150) + (200 * rate150To350) + ((numberOfUnits - 350) * rateFrom350)) * additionalSurcharge;
            }

            Console.WriteLine($"The price for electricity is: {priceForElectricity:N2} PLN");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nDo you want to calculate a different used electricity?");
            Console.WriteLine("Press Y - YES or N - NO");
            Console.ResetColor();
            ConsoleKeyInfo keyPressed = Console.ReadKey();
            if (keyPressed.Key == ConsoleKey.Y)
            {
                Console.WriteLine();
                Console.WriteLine();
                goto ParameterizedThreadStart7;
            }
            else if (keyPressed.Key == ConsoleKey.N)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nEND OF TASK 7.\nPress any key to back main menu.");
                Console.ResetColor();
                Console.ReadKey();
                ShowMenu.ShowAllMenu();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nIncorrect value - END OF TASK 7.\nPress any key to back main menu.");
                Console.ResetColor();
                Console.ReadKey();
                ShowMenu.ShowAllMenu();
            }
        }
    }
}
