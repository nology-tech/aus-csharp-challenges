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

            //[TestInitialize]
            //public void SetUp()
            //{
                
            //    calculator = new Calculator(50, 20);
            //}

    // Testing fields, constructor and getters
    // Uncomment the tests below when you have completed the getters

        //    [TestMethod]
        //    public void GetHasBattery_ValidInput_ReturnsTrueByDefault(){
        //       Assert.isTrue(calculator.GetHasBattery());
        //    }

        //    [TestMethod]
        //    public void GetFirstInput_ValidFields_ReturnsInitialValue(){
        //        double firstInput = calculator.GetFirstInput();
        //        Assert.AreEqual(50, firstInput);
        //    }

        //    [TestMethod]
        //    public void GetSecondInput_ValidFields_ReturnsInitialValue(){
        //        double secondInput = calculator.GetSecondInput();
        //        Assert.AreEqual(20, secondInput);
        //    }

    //// Testing setters and getters
    //// Uncomment the tests when you have completed the setters

        //    [TestMethod]
        //    public void SetHasBattery_ValidInput_ReturnsFalse(){
        //        calculator.SetHasBattery(false);
        //        Assert.IsFalse(calculator.GetHasBattery());
        //    }

        //[TestMethod]
        //public void SetHasBattery_ValidInput_ReturnsTrue(){
        //        calculator.SetHasBattery(false);
        //        calculator.SetHasBattery(true);
        //        Assert.IsTrue(calculator.GetHasBattery());
        //    }

        //[TestMethod]
        //public void SetFirstInput_ValidInput_ReturnsNewValue() {
        //        calculator.SetFirstInput(2000.20);
        //        double updatedFirstInput = calculator.GetFirstInput();
        //        Assert.AreEqual(2000.20, updatedFirstInput);
        //    }

        //[TestMethod]
        //public void SetSecondInput_ValidInput_ReturnsNewValue() {
        //        calculator.SetSecondInput(45);
        //        double updatedSecondInput = calculator.GetSecondInput();
        //        Assert.AreEqual(45, updatedSecondInput);
        //    }

    // Testing calculateAddition
    // Uncomment the tests below when you have completed the calculateAddition method

        //[TestMethod]
        //public void CalculateAddition_ValidFields_ReturnsAddition() {
        //        double result = calculator.CalculateAddition();
        //        Assert.AreEqual(70, result);
        //    }

        //[TestMethod]
        //public void CalculateAddition_UpdatedValidFields_ReturnsAddition() {
        //        calculator.SetFirstInput(450.44);
        //        calculator.SetSecondInput(.56);
        //        double result = calculator.CalculateAddition();
        //        Assert.AreEqual(451, result);
        //    }

        //[TestMethod]
        //public void CalculateAddition_InvalidHasBattery_ReturnsNegativeOne() {
        //        calculator.SetHasBattery(false);
        //        double result = calculator.CalculateAddition();
        //        Assert.AreEqual(-1, result);
        //    }

    //Testing calculateDivision
    //Uncomment the tests below when you have completed the calculateDivision method


        //[TestMethod]
        //public void CalculateDivision_ValidFields_ReturnsDivision(){
        //        double result = calculator.CalculateDivision();
        //        Assert.AreEqual(2.5, result);
        //    }

        //[TestMethod]
        //public void CalculateDivision_UpdatedValidFields_ReturnsDivision(){
        //        calculator.SetFirstInput(10_000);
        //        calculator.SetSecondInput(15);
        //        double result = calculator.CalculateDivision();
        //        Assert.AreEqual(666.6666666666666, result);
        //    }

        //[TestMethod]
        //public void CalculateDivision_InvalidSecondInput_ReturnsZero(){
        //        calculator.SetSecondInput(0);
        //        double result = calculator.CalculateDivision();
        //        Assert.AreEqual(0, result);
        //    }

        //[TestMethod]
        //public void CalculateDivision_InvalidHasBattery_ReturnsNegativeOne(){
        //       calculator.SetHasBattery(false);
        //       double result = calculator.CalculateDivision();
        //        Assert.AreEqual(-1, result);
        //    }

        //[TestMethod]
        //public void CalculateDivision_InvalidHasBatteryAndSecondInput_ReturnsNegativeOne(){
        //        calculator.SetSecondInput(0);
        //        calculator.SetHasBattery(false);
        //        double result = calculator.CalculateDivision();
        //        Assert.AreEqual(-1, result);
        //    }
    }
}
