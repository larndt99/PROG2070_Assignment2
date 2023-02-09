﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TriangleSolverTest;


namespace TriangleSolverTest
{
	[TestFixture]
	public class TriangleSolverTest
	{
		[Test]
		public void triangleSolver_input333_expectEquilateral()
		{
			//Arrange
			int firstSide = 3;
			int secondSide = 3;
			int thirdSide = 3;
			string expected = "Based on all sides being equal, the type of triangle is an EQUILATERAL";

			//Act
			string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

			//Assert
			Assert.AreEqual(expected, actual);

        }

		[Test]
        public void triangleSolver_input886_expectIsosceles()
        {
            //Arrange
            int firstSide = 8;
            int secondSide = 8;
            int thirdSide = 6;
            string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void triangleSolver_input655_expectIsosceles()
        {
            //Arrange
            int firstSide = 6;
            int secondSide = 5;
            int thirdSide = 5;
            string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void triangleSolver_input323_expectIsosceles()
        {
            //Arrange
            int firstSide = 3;
            int secondSide = 2;
            int thirdSide = 3;
            string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }

}

