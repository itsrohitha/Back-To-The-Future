using System;

namespace Back_To_The_Future_Day_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an Integer: ");
            try
            {
                string input = Console.ReadLine();
                int Year = int.Parse(input);
                if ((Year < 2019) && (Year > 0))
                {
                    while (Year < 2019)
                    {
                        Console.WriteLine("The year is " + Year.ToString());
                        Year++;
                    }
                }
                else if (Year > 2018)
                {
                    while(Year > 2018)
                    {
                        Console.WriteLine("The year is " + Year.ToString());
                        Year--;
                    }
                }
                else
                {
                    Console.WriteLine("What are you doing?");
                }
            }
            catch
            {
                Console.WriteLine("Please enter an integer");
            }
        }
    }
}
