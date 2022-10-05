using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // First create an char[], it must contain 6 numbers and 3 letters - name it arr
            var arr = new char[] { '1', '2', '3', '4', '5', '6', 'a', 'b', 'c' };

            // Create a list called numbers that will hold integers
            var numbers = new List<int>();

            // Create an string variable with an empty string initializer - name it str
            var str = "";


            //TODO START HERE:

            // Make a foreach loop to iterate through your character array
            foreach (var item in arr)
            {
                // Now create a try catch
                int number;
                try
                {
                    str = item.ToString();
                    number = int.Parse(str);

                    numbers.Add(number);
                }

                // Inside your try block
                // set your string variable to each array element in your char[] to .ToString()
                // Now, using int.Parse, parse your string variable and store in an int variable
                // Then add each int to your list

                // catch your Exception:
                // in the scope of your catch you can use the following,
                catch (Exception e)
                {
                    Console.WriteLine($"Unable to Parse '{item}'");
                }

            }
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

        }
    }
}