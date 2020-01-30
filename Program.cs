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

                

                if ((value_of_input >= 1) && (value_of_input <= 100))
                {
                    Console.WriteLine("The For Loop will iterate " + value_of_input.ToString() + " times.");
                }


                // Here is the For Loop

                for (int i = 0; i < value_of_input; i++)

                    // If the value of user input is between 1 and 100, execute a For Loop

                    if ((value_of_input >= 1) && (value_of_input <= 100))
                  

                {
                    Console.WriteLine("You have entered" + value_of_input.ToString()+"." + " This is the current integer value in the loop: " + i.ToString());
            }

                    // Pause the program and await the user to press a key to end the program

                    Console.ReadKey(true);
                
            }
            catch

            {

              

                Console.WriteLine("Press any key to exit the program ...");

                Console.ReadKey(true);

            }
            }
    }
}
