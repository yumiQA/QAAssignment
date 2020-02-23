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
    public static class TriangleSolver
    {
        /// <summary>
        /// To analyze if it is a triangle and show what kind of triangle is 
        /// </summary>
        /// <param name="inputOne">inputOne</param>
        /// <param name="inputTwo">inputTwo</param>
        /// <param name="inputThree">inputThree</param>
        /// <returns></returns>
        public static string Analyze(int inputOne, int inputTwo, int inputThree)
        {
            if ((inputOne + inputTwo > inputThree) && (inputTwo + inputThree > inputOne) &&
                (inputOne + inputThree > inputTwo))
            {

                if (inputOne == inputTwo || inputTwo == inputThree || inputOne == inputThree)
                {
                    if ((inputOne == inputTwo) && (inputTwo == inputThree))
                    {
                        return "Triangle Equilateral";
                    }
                    else
                    {
                        return "Triangle Isosceles";
                    }

                }
                else
                {
                    return "Triangle Scalene";
                }

            }
            else
            {
                return "Not a Triangle";
            }

        }

    }
}
