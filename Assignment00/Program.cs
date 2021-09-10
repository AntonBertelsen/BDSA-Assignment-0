using System;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            ValidateLeapYear(Console.ReadLine());
        }

        public static void ValidateLeapYear(string input)
        {
            try
            {
                // Attempt to convert year to int32. Exceptions are caught by try catch
                int year = Convert.ToInt32(input);
                
                // Make sure the input is after the year 1582. if not through an exception - cought by try catch
                if(year <= 1582)
                    throw new Exception();
                    
                // Test numeric input against leap year rules
                Console.WriteLine(year % 4 == 0 && year % 100 != 0 || year % 400 == 0 ? "yay" : "nay");
            }
            catch (Exception e)
            {
                //Prompt user to give correctly formatted and valid input
                Console.WriteLine("Please enter a numeric year after 1582. For instance '2021'");
            }
        }
    }
}
