using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using assignment2;
using NUnit.Framework;

namespace Analyze_Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Analyze_InputA1B1C1_ExpectedOutputEquilateral()
        {
            //Arrange
            int a = 1;
            int b = 1;
            int c = 1;
            string expected = "equilateral";
            string actual = string.Empty;

            //Act
            actual = TriangleSolver.Analyze(a, b, c);

            //Assert
            Assert.AreEqual(expected, actual);
        }        

        [Test]
        public void Analyze_InputA2B2C3_ExpectedOutputIsosceles()
        {
            //Arrange
            int a = 2;
            int b = 2;
            int c = 3;
            string expected = "isosceles";
            string actual = string.Empty;

            //Act
            actual = TriangleSolver.Analyze(a, b, c);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Analyze_InputA2B3C2_ExpectedOutputIsosceles()
        {
            //Arrange
            int a = 2;
            int b = 3;
            int c = 2;
            string expected = "isosceles";
            string actual = string.Empty;

            //Act
            actual = TriangleSolver.Analyze(a, b, c);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Analyze_InputA3B2C2_ExpectedOutputIsosceles()
        {
            //Arrange
            int a = 3;
            int b = 2;
            int c = 2;
            string expected = "isosceles";
            string actual = string.Empty;

            //Act
            actual = TriangleSolver.Analyze(a, b, c);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Analyze_InputA2B3C4_ExpectedOutputScalene()
        {
            //Arrange
            int a = 2;
            int b = 3;
            int c = 4;
            string expected = "scalene";
            string actual = string.Empty;

            //Act
            actual = TriangleSolver.Analyze(a, b, c);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Analyze_InputA1B1C2_ExpectedOutputNotPossible()
        {
            //Arrange
            int a = 1;
            int b = 1;
            int c = 2;
            string expected = "not possible";
            string actual = string.Empty;

            //Act
            actual = TriangleSolver.Analyze(a, b, c);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Analyze_InputA2B1C1_ExpectedOutputNotPossible()
        {
            //Arrange
            int a = 2;
            int b = 1;
            int c = 1;
            string expected = "not possible";
            string actual = string.Empty;

            //Act
            actual = TriangleSolver.Analyze(a, b, c);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Analyze_InputA1B2C1_ExpectedOutputNotPossible()
        {
            //Arrange
            int a = 1;
            int b = 2;
            int c = 1;
            string expected = "not possible";
            string actual = string.Empty;

            //Act
            actual = TriangleSolver.Analyze(a, b, c);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Analyze_InputA2B5C10_ExpectedOutputNotPossible()
        {
            //Arrange
            int a = 2;
            int b = 5;
            int c = 10;
            string expected = "not possible";
            string actual = string.Empty;

            //Act
            actual = TriangleSolver.Analyze(a, b, c);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
