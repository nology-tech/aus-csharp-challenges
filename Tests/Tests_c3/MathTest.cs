using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenges.c3_classes;
using Math = Challenges.c3_classes.Math;

namespace Tests.c3
{
    [TestClass]
    public class MathTest
    {
        //public Math math;

    //[TestInitialize]
    //public void SetUp()
    //    {
    //        math = new Math();
    //    }

    // Testing fields, getters and setters
    // Uncomment the tests below when you have completed the getters

        //[TestMethod]
        //public void GetPI_ValidFields_ReturnsCorrectNumber()
        //{
        //    double result = math.GetPI();
        //    Assert.AreEqual(3.141592653589793, result);
        //}

        //[TestMethod]
        //public void SetPI_ValidInput_UpdatesPIField()
        //{
        //    math.SetPI(3.14);
        //    double result = math.GetPI();
        //    Assert.AreEqual(3.14, result);
        //}

        //[TestMethod]
        //public void SetPI_InvalidInputs_DoesNotUpdatePIField()
        //{
        //    math.SetPI(3.2);
        //    double overRange = math.GetPI();
        //    Assert.AreEqual(3.141592653589793, overRange);

        //    math.SetPI(3);
        //    double underRange = math.GetPI();
        //    Assert.AreEqual(3.141592653589793, underRange);
        //}

    // Testing min
    // Uncomment the tests below when you have completed the min method


        //[TestMethod]
        //public void Min_ValidInputs_ReturnsFirstNumber()
        //{
        //    double result = math.Min(2, 5);
        //    Assert.AreEqual(2, result);
        //}

        //[TestMethod]
        //public void Min_ValidInputs_ReturnsSecondNumber()
        //{
        //    double result = math.Min(17, 5);
        //    Assert.AreEqual(5, result);
        //}

        //[TestMethod]
        //public void Min_ValidInputs_ReturnsEqual()
        //{
        //    double result = math.Min(17, 17);
        //    Assert.AreEqual(17, result);
        //}

    // Testing max
    // Uncomment the tests below when you have completed the max method

        //[TestMethod]
        //public void Max_ValidInputs_ReturnsFirstNumber()
        //{
        //    double result = math.Max(2, 5);
        //    Assert.AreEqual(5, result);
        //}

        //[TestMethod]
        //public void Max_ValidInputs_ReturnsSecondNumber()
        //{
        //    double result = math.Max(17, 5);
        //    Assert.AreEqual(17, result);
        //}

        //[TestMethod]
        //public void Max_ValidInputs_ReturnsEqual()
        //{
        //    double result = math.Max(17, 17);
        //    Assert.AreEqual(17, result);
        //}

    // Testing calculateCircleArea
    // Uncomment the tests below when you have completed the calculateCircleArea method

        //[TestMethod]
        //public void CalculateCircleArea_ValidInputs_ReturnsArea()
        //{
        //    double result = math.CalculateCircleArea(45);
        //    Assert.AreEqual(6361.725123519331, result);
        //}

        //[TestMethod]
        //public void CalculateCircleArea_ValidInputsUpdatedField_ReturnsArea()
        //{
        //    math.SetPI(3.14);
        //    double result = math.CalculateCircleArea(45);
        //    Assert.AreEqual(6358.5, result);
        //}

        //[TestMethod]
        //public void CalculateCircleArea_InvalidInputs_ReturnsNegativeOne()
        //{
        //    double result = math.CalculateCircleArea(0);
        //    Assert.AreEqual(-1, result);
        //}

    //Testing pow
    // Uncomment the tests below when you have completed the pow method

        //[TestMethod]
        //public void Pow_ValidInputs_ReturnsCorrectNumber()
        //{
        //    double result = math.Pow(2, 5);
        //    Assert.AreEqual(32.0, result);
        //}


    }
}