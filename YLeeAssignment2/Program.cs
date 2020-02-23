using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Name: Yumi Lee
Assignment: Assignment2
This program is for checking triangle type
Course Code: PROG2070 Software Quality Assurance
Professor: Rob Bowyer
Date: February 22, 2020 */

namespace YLeeAssignment2
{

    class Program
    {
        /// <summary>
        /// To show the menu
        /// </summary>
        static void ShowMenu()
        {
            Console.WriteLine("1. Enter triangle dimensions");
            Console.WriteLine("2. Exit");
        }

        /// <summary>
        /// To to try  catch and validation
        /// </summary>
        /// <param name="input">input</param>
        /// <returns></returns>
        static int DoTryCatch(string input)
        {
            int parsedInput = -1;
            try
            {
                parsedInput = int.Parse(input);

                if (parsedInput <= 0)
                {
                    Console.WriteLine("The triangle dimension should larger than 0");
                    Console.WriteLine();
                    parsedInput = -1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                parsedInput = -1;
                Console.WriteLine();
            }

            return parsedInput;
          
        }

        static void Main(string[] args)
        {            
            int menuSelectFromUser = 0;
            
            Triangle triangle = new Triangle();

            do
            {
                ShowMenu();

                menuSelectFromUser = DoTryCatch(Console.ReadLine());
                 
                if (menuSelectFromUser == 1)
                {
                    int firstDimension;
                    int secondDimension;
                    int thirdDimension;

                    do
                    {
                        Console.WriteLine("Please input <FIRST> dimension of the triangle");
                        firstDimension = DoTryCatch(Console.ReadLine());

                    } while (firstDimension == -1);

                    do
                    {
                        Console.WriteLine("Please input <SECOND> dimension of the triangle");
                        secondDimension = DoTryCatch(Console.ReadLine());


                    } while (secondDimension == -1);

                    do
                    {
                        Console.WriteLine("Please input <THIRD> dimension of the triangle");
                        thirdDimension = DoTryCatch(Console.ReadLine());

                    } while (thirdDimension == -1);

                    triangle.SetTriangle(firstDimension, secondDimension, thirdDimension);

                    Console.WriteLine();
                    Console.WriteLine("******** Report *********");
                    Console.WriteLine(TriangleSolver.Analyze(firstDimension, secondDimension, thirdDimension));
                    Console.WriteLine();
                    Console.WriteLine("*************************");
                }
                else if(menuSelectFromUser == 2)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("The input is not integer 1 or 2");
                }
             
                Console.WriteLine("Please press anykey to the menu");
                Console.ReadLine();
                Console.Clear();

            } while (true);

        }
    }
}
