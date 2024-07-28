using System;

class Program 
{
  public static void Main (string[] args) 
  {
    while (true)
                {
                    DisplayMenu();

                    string choice = Console.ReadLine().Trim();
                    if (choice == "1")
                    {
                        CalculateRevenue();
                    }
                    else if (choice == "2")
                    {
                        Console.WriteLine("\nThank you for using the Greenville Revenue App, good-bye!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please select 1 or 2.");
                    }
                }
            }

            static void DisplayMenu()
            {
                Console.WriteLine("\n************************************");
                Console.WriteLine("*  The stars shine in Greenville.  *");
                Console.WriteLine("************************************");
                Console.WriteLine("\nPlease Enter the following number below from the following menu:");
                Console.WriteLine("1. CALCULATE Greenville Revenue Year-Over-Year");
                Console.WriteLine("2. Exit");
            }

            static void CalculateRevenue()
            {
                try
                {
                    Console.Write("Enter the number of contestants last year: ");
                    int lastYearContestants = int.Parse(Console.ReadLine().Trim());

                    Console.Write("Enter the number of contestants this year: ");
                    int thisYearContestants = int.Parse(Console.ReadLine().Trim());

                    int revenue = thisYearContestants * 25;

                    Console.WriteLine($"\nLast year's competition had {lastYearContestants} contestants, and this year's has {thisYearContestants} contestants");
                    Console.WriteLine($"Revenue expected this year is ${revenue}");
                    Console.WriteLine($"It is {(thisYearContestants > lastYearContestants ? "true" : "false")} that this year's competition is bigger than last year's.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter numeric values for the number of contestants.");
                }
            }
        }
    
 