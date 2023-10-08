// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<double> scooterSales = new List<double>();

        while (true)
        {
            Console.WriteLine("Manav's Scooter Sales Application");
            Console.WriteLine("1. Enter 1 to enter scooter sales.");
            Console.WriteLine("2. Enter 2 to display the average amount a scooter is sold for.");
            Console.WriteLine("3. Enter 3 to display the lowest amount a scooter is sold for.");
            Console.WriteLine("4. Enter 4 to exit.");
            Console.Write("Enter your choice: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the amount of scooter sale: ");
                        if (double.TryParse(Console.ReadLine(), out double saleAmount) && saleAmount >= 0)
                        {
                            scooterSales.Add(saleAmount);
                            Console.WriteLine("Sale added successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input for sale amount. Please enter a valid non-negative number.");
                        }
                        break;

                    case 2:
                        if (scooterSales.Count > 0)
                        {
                            double average = scooterSales.Average();
                            Console.WriteLine($"Average scooter sale amount: {average:C}");
                        }
                        else
                        {
                            Console.WriteLine("No sales data available yet.");
                        }
                        break;

                    case 3:
                        if (scooterSales.Count > 0)
                        {
                            double lowestSale = scooterSales.Min();
                            Console.WriteLine($"Lowest scooter sale amount: {lowestSale:C}");
                        }
                        else
                        {
                            Console.WriteLine("No sales data available yet.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Exiting the program. Goodbye!");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option (1, 2, 3, or 4).");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numeric choice.");
            }

            Console.WriteLine();
        }
    }
}

