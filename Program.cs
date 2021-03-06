﻿/*

 Author: Alfred Williams
 Date: 1/30/20
Comments: This C# Console application code demonstrates the use of iteration statements after getting input from users

*/




using System;

namespace Iteration_Statment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for input

            Console.WriteLine("Enter an Integer value between 1 and 100 to execute a For Loop: ");

            /*
            Use the try catch block to validate user input.
            If the user provides bad input, the catch block
            will handle the error and a message will be displayed.
            */

            try
            {
                // This variable will gather data from user input 

                string input = Console.ReadLine();

                // This variable will be used to perform the various iterative statements and is parsed as an integer

                int value_of_input = int.Parse(input);

                /* 
                This conditional IF/ELSE IF/ELSE statement is used to test the values of user input.
                Depending on the value of the user input between 1 and 100, a For Loop iterative statement will execute. 
                */

                if (value_of_input > 100)

                {
                    Console.WriteLine("Cannot exceed 100");
                }

                if ((value_of_input >= 1) && (value_of_input <= 100))
                {
                    Console.WriteLine("The For Loop will iterate " + value_of_input.ToString() + " times.");
                }


                // Here is the For Loop

                if ((value_of_input >= 1) && (value_of_input <= 100))



              

                    for (int i = 1; i <= value_of_input; i++)

                    // If the value of user input is between 1 and 100, execute a For Loop

                    


                    {
                        Console.WriteLine("You have entered" + value_of_input.ToString() + "." + " This is the current integer value in the loop: " + i.ToString());
                    }

                if (value_of_input < 1)
                {
                    Console.WriteLine("Cannot be below 0");
                }

                // Pause the program and await the user to press a key to end the program

                Console.ReadKey(true);
                
            }
            catch

            {

                Console.WriteLine("Please enter a number between 1 and 100");

                Console.WriteLine("Press any key to exit the program ...");

                Console.ReadKey(true);

            }
            }
    }
}
