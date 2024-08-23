using System;

namespace BOOP_02_09
{
    class Program
    {
        static void Main(string[] args)
        {
            // Format using string interpolations
            decimal price = 582.5555M;

            //Format as Currency
            Console.WriteLine($"Product A costs: {price:C}");
            Console.WriteLine($"Product B costs: {price * 5:C}");

            // Format the price right adjusted in a column 20 characters wide and 4 decimals
            Console.WriteLine();
            Console.WriteLine($"Product A costs: {price,20:C4}");
            Console.WriteLine($"Product B costs: {price * 5,20:C4}");

            // Format a byte and int in hex
            byte data = 0xAF;
            Console.WriteLine();
            Console.WriteLine($@"""data"" in decimal: {data}");
            Console.WriteLine($"{data} in hexdecimal 2digits: 0x{data:X2}");
            Console.WriteLine($"{data} in hexdecimal 4digits: 0x{data:X4}");


            string book1 = "Robinson Cruisoe";
            string author1 = "Daniel Defoe";
            decimal price1 = 125.50M;
            string book2 = "Count of Monte Christo";
            string author2 = "Alexandre Dumas";
            decimal price2 = 119.75M;

            // Format in a table
            Console.WriteLine();
            Console.WriteLine($"{"Article",-7} {"Title",-30} {"Author",-30} {"Price",20}");
            Console.WriteLine($"{"1:",-7} {book1,-30} {author1,-30} {price1,20:C2}");
            Console.WriteLine($"{"2:",-7} {book2,-30} {author2,-30} {price2,20:C2}");

            Console.WriteLine();
            Console.WriteLine("Various PI precisions");
            Console.WriteLine();
            Console.WriteLine("Various PI and E precisions");
            Console.WriteLine($"{"Decimals",-9}{"Math.PI",20}{"Math.E",20}");
            Console.WriteLine($"{"2",-9}{Math.PI,20:N2}{Math.E,20:N2}");
            Console.WriteLine($"{"4",-9}{Math.PI,20:N4}{Math.E,20:N4}");
            Console.WriteLine($"{"6",-9}{Math.PI,20:N6}{Math.E,20:N6}");
            Console.WriteLine($"{"8",-9}{Math.PI,20:N8}{Math.E,20:N8}");

        }
    }
}
//Exercises:
//1.    Declare two variable, var1 and var2 of type float. Assign them value and print out the varible names and the values
//      using String Interpolation, var1 should be printed with 2 decimals and var2 in 4 decimals. 
//      - hint the format specifier for numeric values is N
//2.    Modify Line 39 and 40 so the price is written without the suffix "kr"
//3.    Write a program that printout a table of the mathimatical constants Pi (Math.PI) and E (Math.E) with 
//      decimals 2 to 8. The table should look like: 
//      Various PI and E precisions
//      Decimals              Math.PI              Math.E
//      2                        3,14                2,72
//      4                      3,1416              2,7183
//      6                    3,141593            2,718282
//      8                  3,14159265          2,71828183
