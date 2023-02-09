using System;
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
		public void triangleSolver_input333expectEquilateral()
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
	}
}

