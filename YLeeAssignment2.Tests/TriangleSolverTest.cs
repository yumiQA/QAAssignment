using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

/* Name: Yumi Lee
Assignment: Assignment2
This program is for checking triangle type
Course Code: PROG2070 Software Quality Assurance
Professor: Rob Bowyer
Date: February 22, 2020 */

namespace YLeeAssignment2.Tests
{
    [TestFixture]
    public class TriangleSolverTest
    {
        //To see the result is Triangle Scalene
        [Test]
        public void TriangleSolverMethod_Given_3_4_5_ResultIs_Triangle_Scalene()
        {
            //Arrange
            int firstDimension = 3;
            int secondDimension = 4;
            int thirdDimension = 5;

            //Act
            string result = TriangleSolver.Analyze(firstDimension, secondDimension, thirdDimension);

            //Asset
            Assert.AreEqual("Triangle Scalene", result);
        }

        //To see the result is Triangle Equilateral
        [Test]
        public void TriangleSolverMethod_Given_1_1_1_ResultIs_Triangle_Scalene()
        {
            //Arrange
            int firstDimension = 1;
            int secondDimension = 1;
            int thirdDimension = 1;

            //Act
            string result = TriangleSolver.Analyze(firstDimension, secondDimension, thirdDimension);

            //Asset
            Assert.AreEqual("Triangle Equilateral", result);
        }

        //To see the result is Triangle Isosceles
        [Test]
        public void TriangleSolverMethod_Given_5_7_7_ResultIs_Triangle_Scalene()
        {
            //Arrange
            int firstDimension = 5;
            int secondDimension = 7;
            int thirdDimension = 7;

            //Act
            string result = TriangleSolver.Analyze(firstDimension, secondDimension, thirdDimension);

            //Asset
            Assert.AreEqual("Triangle Isosceles", result);
        }

        //To see the result is not a triangle when the third input > second input > first input
        [Test]
        public void TriangleSolverMethod_Given_1_2_3_ResultIs_Triangle_Scalene()
        {
            //Arrange
            int firstDimension = 1;
            int secondDimension = 2;
            int thirdDimension = 3;

            //Act
            string result = TriangleSolver.Analyze(firstDimension, secondDimension, thirdDimension);

            //Asset
            Assert.AreEqual("Not a Triangle", result);
        }

        //To see the result is not a triangle when the second input > third input > first input
        [Test]
        public void TriangleSolverMethod_Given_1_3_2_ResultIs_Triangle_Scalene()
        {
            //Arrange
            int firstDimension = 1;
            int secondDimension = 3;
            int thirdDimension = 2;

            //Act
            string result = TriangleSolver.Analyze(firstDimension, secondDimension, thirdDimension);

            //Asset
            Assert.AreEqual("Not a Triangle", result);
        }

        //To see the result is not a triangle when the first input > second input > third input
        [Test]
        public void TriangleSolverMethod_Given_3_2_1_ResultIs_Triangle_Scalene()
        {
            //Arrange
            int firstDimension = 3;
            int secondDimension = 2;
            int thirdDimension = 1;

            //Act
            string result = TriangleSolver.Analyze(firstDimension, secondDimension, thirdDimension);

            //Asset
            Assert.AreEqual("Not a Triangle", result);
        }

    }
}
