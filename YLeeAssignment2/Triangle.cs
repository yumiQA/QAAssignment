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
        private int triangleDimension;

        public Triangle()
        {
            triangleDimension = 1;
        }

        public Triangle(int triangleDimension)
        {
            this.triangleDimension = triangleDimension;
        }

        public int GetTriangle()
        {
            return triangleDimension;
        }

        public void SetTriangle(int triangle)
        {
            this.triangleDimension = triangle;
        }


    }
}
