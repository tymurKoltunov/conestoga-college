using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using AwesomeCalculator;

namespace UnitTests
{
    [TestFixture]
    public class CalcTests
    {
        [Test]
        public void Addition_input12p23And54p65_expected66p88()
        {
            //Arrange
            double first = 12.23;
            double second = 54.65;
            double expected = 66.88;
            double actual = 0;
            Calc c = new Calc(first, second);

            //Act
            actual = c.GetAddition();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Addition_input21p56And0p00_expected21p56()
        {
            //Arrange
            double first = 21.56;
            double second = 0.00;
            double expected = 21.56;
            double actual = 0;
            Calc c = new Calc(first, second);

            //Act
            actual = c.GetAddition();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Addition_inputNeg56p44And56p44_expected0p00()
        {
            //Arrange
            double first = -56.44;
            double second = 56.44;
            double expected = 0.00;
            double actual = 0;
            Calc c = new Calc(first, second);

            //Act
            actual = c.GetAddition();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Subtraction_input77p33And22p12_expected55p21()
        {
            //Arrange
            double first = 77.33;
            double second = 22.12;
            double expected = 55.21;
            double actual = 0;
            Calc c = new Calc(first, second);

            //Act
            actual = c.GetSubtraction();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Subtraction_input10p22And0p00_expected10p22()
        {
            //Arrange
            double first = 10.22;
            double second = 0.00;
            double expected = 10.22;
            double actual = 0;
            Calc c = new Calc(first, second);

            //Act
            actual = c.GetSubtraction();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Subtraction_input77p33And80p00_expectedNeg2p67()
        {
            //Arrange
            double first = 77.33;
            double second = 80.00;
            double expected = -2.67;
            double actual = 0;
            Calc c = new Calc(first, second);

            //Act
            actual = c.GetSubtraction();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Multiplication_input77p33And0p00_expected0p00()
        {
            //Arrange
            double first = 77.33;
            double second = 0.00;
            double expected = 0.00;
            double actual = 0;
            Calc c = new Calc(first, second);

            //Act
            actual = c.GetMultiplication();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Multiplication_input77p33AndNeg1p00_expectedNeg77p33()
        {
            //Arrange
            double first = 77.33;
            double second = -1.00;
            double expected = -77.33;
            double actual = 0;
            Calc c = new Calc(first, second);

            //Act
            actual = c.GetMultiplication();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Multiplication_input77p33And12p44_expected961p99()
        {
            //Arrange
            double first = 77.33;
            double second = 12.44;
            double expected = 961.99;
            double actual = 0;
            Calc c = new Calc(first, second);

            //Act
            actual = c.GetMultiplication();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Division_input77p33AndNeg1p00_expectedNeg77p33()
        {
            //Arrange
            double first = 77.33;
            double second = -1;
            double expected = -77.33;
            double actual = 0;
            Calc c = new Calc(first, second);

            //Act
            actual = c.GetDivision();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Division_input0p00And44p98_expected0()
        {
            //Arrange
            double first = 0.00;
            double second = 44.98;
            double expected = 0;
            double actual = 0;
            Calc c = new Calc(first, second);

            //Act
            actual = c.GetDivision();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Division_input77p33And0p00_expectedInfinity()
        {
            //Arrange
            double first = 77.33;
            double second = 0;
            double actual = 0;
            double expected = Double.PositiveInfinity;
            Calc c = new Calc(first, second);

            //Act
            actual = c.GetDivision();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
    [TestFixture]
    public class Mut_Tests
    {
        [Test]
        public void Division_input77p33AndNeg2p00_expectedNeg38p66()
        {
            //Arrange
            double first = 77.33;
            double second = -2;
            double expected = -38.66;
            double actual = 0;
            Calc c = new Calc(first, second);

            //Act
            actual = c.GetDivision();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Division_input10p00And44p98_expected0p22()
        {
            //Arrange
            double first = 10.00;
            double second = 44.98;
            double expected = 0.22;
            double actual = 0;
            Calc c = new Calc(first, second);

            //Act
            actual = c.GetDivision();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Division_input77p33And77p33_expected1p00()
        {
            //Arrange
            double first = 77.33;
            double second = 77.33;
            double actual = 0;
            double expected = 1;
            Calc c = new Calc(first, second);

            //Act
            actual = c.GetDivision();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Division_input1p33And1p34_expected2p67()
        {
            //Arrange
            double first = 1.33;
            double second = 1.34;
            double actual = 0;
            double expected = 0.99;
            Calc c = new Calc(first, second);

            //Act
            actual = c.GetDivision();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}