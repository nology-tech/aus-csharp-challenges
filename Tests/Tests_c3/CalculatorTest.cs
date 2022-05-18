using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenges.c3_classes;

namespace Tests.c3
{
    [TestClass]
    public class Tests_calculator
    {
        private Calculator calculator;

        // Uncomment the BeforeEach when you have completed the constructor

        [TestInitialize]
        public void SetUp()
        {

            calculator = new Calculator(50, 20);
        }

        // Testing fields, constructor and getters
        // Uncomment the tests below when you have completed the getters

        [TestMethod]
        public void GetHasBattery_ValidInput_ReturnsTrueByDefault()
        {
            Assert.IsTrue(calculator.HasBattery);
        }

        [TestMethod]
        public void GetFirstInput_ValidFields_ReturnsInitialValue()
        {
            double firstInput = calculator.FirstInput;
            Assert.AreEqual(50, firstInput);
        }

        [TestMethod]
        public void GetSecondInput_ValidFields_ReturnsInitialValue()
        {
            double secondInput = calculator.SecondInput;
            Assert.AreEqual(20, secondInput);
        }

        // Testing setters and getters
        // Uncomment the tests when you have completed the setters

        [TestMethod]
        public void SetHasBattery_ValidInput_ReturnsFalse()
        {
            calculator.HasBattery = false;
            Assert.IsFalse(calculator.HasBattery);
        }

        [TestMethod]
        public void SetHasBattery_ValidInput_ReturnsTrue()
        {
            calculator.HasBattery = false;
            calculator.HasBattery = true;
            Assert.IsTrue(calculator.HasBattery);
        }

        [TestMethod]
        public void SetFirstInput_ValidInput_ReturnsNewValue()
        {
            calculator.FirstInput = 2000.20;
            double updatedFirstInput = calculator.FirstInput;
            Assert.AreEqual(2000.20, updatedFirstInput);
        }

        [TestMethod]
        public void SetSecondInput_ValidInput_ReturnsNewValue()
        {
            calculator.SecondInput = 45;
            double updatedSecondInput = calculator.SecondInput;
            Assert.AreEqual(45, updatedSecondInput);
        }

        //Testing calculateAddition
        // Uncomment the tests below when you have completed the calculateAddition method

        [TestMethod]
        public void CalculateAddition_ValidFields_ReturnsAddition()
        {
            double result = calculator.CalculateAddition();
            Assert.AreEqual(70, result);
        }

        [TestMethod]
        public void CalculateAddition_UpdatedValidFields_ReturnsAddition()
        {
            calculator.FirstInput = 450.44;
            calculator.SecondInput = .56;
            double result = calculator.CalculateAddition();
            Assert.AreEqual(451, result);
        }

        [TestMethod]
        public void CalculateAddition_InvalidHasBattery_ReturnsNegativeOne()
        {
            calculator.HasBattery = false;
            double result = calculator.CalculateAddition();
            Assert.AreEqual(-1, result);
        }

        //Testing calculateDivision
        //Uncomment the tests below when you have completed the calculateDivision method


        [TestMethod]
        public void CalculateDivision_ValidFields_ReturnsDivision()
        {
            double result = calculator.CalculateDivision();
            Assert.AreEqual(2.5, result);
        }

        [TestMethod]
        public void CalculateDivision_UpdatedValidFields_ReturnsDivision()
        {
            calculator.FirstInput = 10000;
            calculator.SecondInput = 15;
            double result = calculator.CalculateDivision();
            Assert.AreEqual(666.6666666666666, result);
        }

        [TestMethod]
        public void CalculateDivision_InvalidSecondInput_ReturnsZero()
        {
            calculator.SecondInput = 0;
            double result = calculator.CalculateDivision();
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void CalculateDivision_InvalidHasBattery_ReturnsNegativeOne()
        {
            calculator.HasBattery = false;
            double result = calculator.CalculateDivision();
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void CalculateDivision_InvalidHasBatteryAndSecondInput_ReturnsNegativeOne()
        {
            calculator.SecondInput = 0;
            calculator.HasBattery = false;
            double result = calculator.CalculateDivision();
            Assert.AreEqual(-1, result);
        }
    }
}
