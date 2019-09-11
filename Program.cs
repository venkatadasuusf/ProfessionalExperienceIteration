/*
 Author: Venkata Dasu
 Date: 9/10/2019
 Comments: This C# Console application code demonstrates the use of 
           conditional statements after getting input from users
*/

using System;

namespace Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many years of experience do you have in professional programming ...");

            try
            {
                string input = Console.ReadLine();

                int experience = int.Parse(input);

                for (int i = 1; i <= experience; i++)
                {
                    Console.WriteLine("You have " + String.Format("{0}", i) + " Years of experience");
                }
                

            } // end of try
            catch
            {
                Console.WriteLine("Please use a integer data type for your experience details next time...");
                Console.WriteLine("Press any key to exit the program and try again...");
                Console.ReadKey(true);
            } // end of catch     
        } // end of Main
    } // end of class
} // end of namespace
