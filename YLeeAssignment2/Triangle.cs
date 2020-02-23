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
    public class Triangle
    {
        private int firstDimension;
        private int secondDimension;
        private int thirdDimension;

        public Triangle()
        {
            firstDimension = 1;
            secondDimension = 1;
            thirdDimension = 1;
        }

        public Triangle(int triangleDimension)
        {
        }

        /// <summary>
        /// to set triangle values in class
        /// </summary>
        /// <param name="firstDimension"></param>
        /// <param name="secondDimension"></param>
        /// <param name="thirdDimension"></param>
        public void SetTriangle(int firstDimension, int secondDimension, int thirdDimension)
        {
            this.firstDimension = firstDimension;
            this.secondDimension = secondDimension;
            this.thirdDimension = thirdDimension;
        }

    }
}
