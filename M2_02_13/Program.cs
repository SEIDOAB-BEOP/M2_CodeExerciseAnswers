using System;

namespace BOOP_02_13_Execise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string firstname = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lastname = Console.ReadLine();

            Console.WriteLine("Enter you birth date yyyy-mm-dd?");
            string sBirthDate = Console.ReadLine();

            DateTime birthdate;
           if (DateTime.TryParse(sBirthDate, out birthdate))
            {
                TimeSpan DaysOfAge = DateTime.Now - birthdate;

                Console.WriteLine($"Hello {firstname} {lastname}! Your age in days is {DaysOfAge.Days}.");
            }
            else
            {
                Console.WriteLine($"Hello {firstname} {lastname}! I cannot determine your age");
            }

        }
    }
}
//      "Hello John Smith! You were born 1996.
//      If age is not an integer (remember int.TryParse()) the output should be
//      "Hello John Smith! I cannot determine your birth year.

