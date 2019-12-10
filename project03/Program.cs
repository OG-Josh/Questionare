/*  Project 03
 *  Written by Joshua Yang
 *  Professor Christopher Boyd
 *  Visual Programming
 *  Due on 09/25/2019
 *  Write a console that takes user inputs
 *  and repeatdly ask questions
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project03
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string input1 = null; //First Q's Input
            string input2 = null; //Second Q's Input
            string input3 = null; // Third Q's Input
            string input4 = null; // Input to confirm if user wants to retry or exit program
            int output1; // Conversion of string to integer for Student ID
            bool flag1 = true; //Flag to continue loop or exit loop based off input4
            //bool input5 = false; // Bool to confirm student status

            while (flag1 == true)
            {
                Console.Clear();
                //=============================================================================================
                //Question 1:
                Console.WriteLine("Welcome to Chapman Class Sign in!");
                Console.Write("Please enter your first and last name: "); //Display Msg for first question
                input1 = Console.ReadLine(); // First Question input assigned to input1

                //=============================================================================================
                //Question 2:

                Console.WriteLine("Welcome " + input1 + "!"); 
                Console.Write("Now please enter your student ID: "); 
                input2 = Console.ReadLine(); 

                //If Statement checks to see if input is a valid integer
                //if not, it will retry the whole loop
                if (int.TryParse(input2, out output1))
                    {
                        Console.Write("Student ID Validated! Press enter to continue!");
                        Console.ReadLine();
                    }
                        else
                        {
                             Console.WriteLine("Student ID invalid! Please try again!");
                             Console.ReadLine();
                             
                             //ADD RETRY LOOP HERE?
                        }

                //=============================================================================================
                //Question 3:

                Console.Write("Finally, are you a student at Chapman University? (Y/N): "); //Display Message asks user if they are a student
                input3 = Console.ReadLine(); //Retrieves user input for input3

                //*************************************************************************************

                //First IF statement checks to see if user is a Chapman student
                if (input3 == "Y" || input3 == "y") //if user typed in Y or y for yes, then code below will execute
                {

                    //Below is a display of information user has entered as according to Project03 Rubric
                    //Summary of user input displayed below
                    Console.WriteLine("Thank you " + input1 + "! You have checked in!");
                    Console.WriteLine("Your student ID is " + output1);
                    Console.WriteLine("And you stated " + input3 + " for Yes to confirm your check in status!");
                    Console.Write("Would you like to try again? (y/n): ");
                    
                    input4 = Console.ReadLine(); 

                 //****************************************   
                    //If statements checks to see if user typed yes or no

                    if (input4 == "Y" || input4 == "y") 
                    {
                        Console.WriteLine("Please press enter to retry!"); 
                        Console.ReadLine();
                    }
                        else if (input4 == "N" || input4 == "n") 
                        {
                            flag1 = false; 
                        }
                    else
                    {
                        Console.WriteLine("Invalid Input. Press ENTER to start over!");
                        Console.ReadLine();
                        //ADD RETRY LOOP HERE???
                    }
                }
                       
                //*****************************************

                // If the user entered N or n for NO, stating that they are not a student at Chapman
                // Program will display ERROR message and return or retry based on user's input

                    else if( input3 == "N" || input3 == "n")
                        {
                            Console.Write("You have to be a student at Chapman to sign in, would you like to try agian? (y/n):");
                            input4 = Console.ReadLine();
                            
                            //Second If statements check to see if user wants to retry proccess again
                            if (input4 == "Y" || input4 == "y")
                            {
                                Console.WriteLine("Please press enter to retry!"); 
                                Console.ReadLine();
                            }
                                else if (input4 == "N" || input4 == "n")
                                {
                                    flag1 = false; //Flag changes to stop while loop
                                }
                        }
                else
                {
                    Console.WriteLine("Invalid Input. Press ENTER to start over!");
                    Console.ReadLine();
                    
                }

                //*************************************************************************************

             //=============================================================================================
            }
        }
    }
}
