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
            StringBuilder builder = new StringBuilder();

            builder.AppendLine();
            builder.AppendLine("****** REPORT *******");

            if ((inputOne + inputTwo > inputThree) && (inputTwo + inputThree > inputOne) && 
                (inputOne + inputThree > inputTwo))
            {
                builder.AppendLine("A. It is a triangle");

                builder.AppendLine();

                if (inputOne == inputTwo || inputTwo == inputThree || inputOne == inputThree)
                {
                    if ((inputOne == inputTwo) && (inputTwo == inputThree))
                    {
                        builder.AppendLine("B.Equilateral");
                    }
                    else
                    {
                        builder.AppendLine("B. Isosceles");
                    }

                }
                else
                {
                    builder.AppendLine("B. Scalene");
                }

            }
            else
            {
                builder.AppendLine("A. It is not a triangle");
            }

            builder.AppendLine("*********************");
            builder.AppendLine();

            return builder.ToString();

        }

    }
}
