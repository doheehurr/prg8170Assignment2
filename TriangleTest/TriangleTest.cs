/*
 *  TriangleTest.cs
 *  Assignment2
 * 
 *  Revision History
 *      Dohee Hur, 2023.06.08: Created
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;
using NUnit.Framework;

namespace TriangleTest
{
    [TestFixture]
    public class TriangleTest
    {
        // 1 Equilateral Triangle
        [Test]
        public void TriangleSolverEquilateralTriangle_Input10and10and10_OutputValidEquilateralTriangle()
        {
            //Arange
            int firstSide = 10;
            int secondSide = 10;
            int thirdSide = 10;

            string expected = "The triangle is valid and is an EQUILATERAL";

            //Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, result);
        }

        // 3 Isosceles Triangles
        [Test]
        public void TriangleSolverValidIsoscelesTriangle_Input20and20and25_OutputValidIsoscelesTriangle()
        {
            //Arange
            int firstSide = 20;
            int secondSide = 20;
            int thirdSide = 25;

            string expected = "The triangle is valid and is an ISOSCELES";

            //Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TriangleSolverValidIsoscelesTriangle_Input6and6and4_OutputValidIsoscelesTriangle()
        {
            //Arange
            int firstSide = 6;
            int secondSide = 6;
            int thirdSide = 4;

            string expected = "The triangle is valid and is an ISOSCELES";

            //Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TriangleSolverValidIsoscelesTriangle_Input8and8and9_OutputValidIsoscelesTriangle()
        {
            //Arange
            int firstSide = 8;
            int secondSide = 8;
            int thirdSide = 9;

            string expected = "The triangle is valid and is an ISOSCELES";

            //Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, result);
        }

        // 5 Scalene Triangles
        [Test]
        public void TriangleSolverValidScaleneTriangle_Input5and6and7_OutputValidScaleneTriangle()
        {
            //Arange
            int firstSide = 5;
            int secondSide = 6;
            int thirdSide = 7;

            string expected = "The triangle is valid and is a SCALENE";

            //Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TriangleSolverValidScaleneTriangle_Input6and16and17_OutputValidScaleneTriangle()
        {
            //Arange
            int firstSide = 6;
            int secondSide = 16;
            int thirdSide = 17;

            string expected = "The triangle is valid and is a SCALENE";

            //Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TriangleSolverValidScaleneTriangle_Input7and26and27_OutputValidScaleneTriangle()
        {
            //Arange
            int firstSide = 7;
            int secondSide = 26;
            int thirdSide = 27;

            string expected = "The triangle is valid and is a SCALENE";

            //Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TriangleSolverValidScaleneTriangle_Input9and16and18_OutputValidScaleneTriangle()
        {
            //Arange
            int firstSide = 9;
            int secondSide = 16;
            int thirdSide = 18;

            string expected = "The triangle is valid and is a SCALENE";

            //Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TriangleSolverValidScaleneTriangle_Input19and20and21_OutputValidScaleneTriangle()
        {
            //Arange
            int firstSide = 19;
            int secondSide = 20;
            int thirdSide = 21;

            string expected = "The triangle is valid and is a SCALENE";

            //Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, result);
        }

        // 3 Tests for Veverifying a Zero Length for One or More Sides
        [Test]
        public void TriangleSolverInvalidTriangle_Input0and6and7_OutputInvalidTriangleWith0()
        {
            //Arange
            int firstSide = 0;
            int secondSide = 6;
            int thirdSide = 7;

            string expected = "At least one side of your triangle has a zero length and is thus invalid";

            //Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TriangleSolverInvalidTriangle_Input0and0and15_OutputInvalidTriangleWith0()
        {
            //Arange
            int firstSide = 0;
            int secondSide = 0;
            int thirdSide = 15;

            string expected = "At least one side of your triangle has a zero length and is thus invalid";

            //Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TriangleSolverInvalidTriangle_Input17and0and16_OutputInvalidTriangleWith0()
        {
            //Arange
            int firstSide = 17;
            int secondSide = 0;
            int thirdSide = 16;

            string expected = "At least one side of your triangle has a zero length and is thus invalid";

            //Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, result);
        }

        // 3 Tests for Verifying an Invalid Response (other than a zero length)
        [Test]
        public void TriangleSolverInvalidTriangle_Input6and4and10_OutputInvalidTriangle()
        {
            //Arange
            int firstSide = 6;
            int secondSide = 4;
            int thirdSide = 10;

            string expected = "A triangle cannot be formed with those numbers"; ;

            //Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TriangleSolverInvalidTriangle_Input3and4and7_OutputInvalidTriangle()
        {
            //Arange
            int firstSide = 3;
            int secondSide = 4;
            int thirdSide = 7;

            string expected = "A triangle cannot be formed with those numbers"; ;

            //Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void  TriangleSolverInvalidTriangle_Input10and10and45_OutputInvalidTriangle()
        {
            //Arange
            int firstSide = 10;
            int secondSide = 10;
            int thirdSide = 45;

            string expected = "A triangle cannot be formed with those numbers"; ;

            //Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
