using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenges.c2_control_flow_extended;

namespace Tests.c2
{
    [TestClass]
    public class Test_GetFullName
    {
        private Challenge challenge;

        [TestInitialize]
        public void Setup()
        {
            challenge = new Challenge();
        }

        [TestMethod]
        public void ValidInput_ReturnsFullNameWithSpace()
        {
            string result = challenge.GetFullName("Sam", "Joyce");
            Assert.AreEqual("Sam Joyce", result);
        }
    }

    [TestClass]
    public class Test_IsWithinRange
    {
        private Challenge challenge;

        [TestInitialize]
        public void Setup()
        {
            challenge = new Challenge();
        }

        [TestMethod]
        public void ValidInput_ReturnsTrueWithinRange()
        {
            bool result = challenge.IsWithinRange(20, 50);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidInput_ReturnsTrueRangeLimit()
        {
            bool result = challenge.IsWithinRange(10, 10);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidInput_ReturnsTrueRangeStart()
        {
            bool result = challenge.IsWithinRange(0, 10);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void InvalidInput_ReturnsFalseOutOfRange()
        {
            bool result = challenge.IsWithinRange(600, 20);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void InvalidInput_ReturnsFalseBelowZero()
        {
            bool result = challenge.IsWithinRange(-50, 20);
            Assert.IsFalse(result);
        }
    }

    [TestClass]
    public class Test_StringCalculator
    {
        private Challenge challenge;

        [TestInitialize]
        public void Setup()
        {
            challenge = new Challenge();
        }

        [TestMethod]
        public void ValidInputs_ReturnsAdditionResult()
        {
            int result = challenge.StringCalculator(10, 20, "+");
            Assert.AreEqual(30, result);
        }

        [TestMethod]
        public void ValidInputs_ReturnsMinusResult()
        {
            int result = challenge.StringCalculator(500, 20, "-");
            Assert.AreEqual(480, result);
        }

        [TestMethod]
        public void ValidInputs_ReturnsDivisionResult()
        {
            int result = challenge.StringCalculator(500, 2, "/");
            Assert.AreEqual(250, result);
        }

        [TestMethod]
        public void ValidInputs_ReturnsMultiplicationResult()
        {
            int result = challenge.StringCalculator(5, 20, "*");
            Assert.AreEqual(100, result);
        }

        [TestMethod]
        public void InvalidInputs_ReturnsMinusOne()
        {
            int invalidFirstNumber = challenge.StringCalculator(-500, 2, "/");
            Assert.AreEqual(-1, invalidFirstNumber);
            int invalidSecondNumber = challenge.StringCalculator(500, -2, "/");
            Assert.AreEqual(-1, invalidSecondNumber);
            int invalidOperator = challenge.StringCalculator(500, -2, "");
            Assert.AreEqual(-1, invalidOperator);
        }
    }

    [TestClass]
    public class Test_ShouldWakeUp
    {
        private Challenge challenge;

        [TestInitialize]
        public void Setup()
        {
            challenge = new Challenge();
        }

        [TestMethod]
        public void ValidInput_ReturnsTrueAfterTenBarking()
        {
            bool result = challenge.ShouldWakeUp(true, 23);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void InvalidInput_ReturnsFalseAfterTenNotBarking()
        {
            bool result = challenge.ShouldWakeUp(false, 23);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidInput_ReturnsTrueBeforeEightBarking()
        {
            bool result = challenge.ShouldWakeUp(true, 5);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void InvalidInput_ReturnsFalseBeforeEightNotBarking()
        {
            bool result = challenge.ShouldWakeUp(false, 5);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidInput_ReturnsFalseNotAfterTen()
        {
            bool result = challenge.ShouldWakeUp(true, 22);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidInput_ReturnsFalseNotBeforeEight()
        {
            bool result = challenge.ShouldWakeUp(true, 8);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void InvalidInput_ReturnsFalseOutOfRange()
        {
            bool result = challenge.ShouldWakeUp(true, 50);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void InvalidInput_ReturnsFalseBelowRange()
        {
            bool result = challenge.ShouldWakeUp(true, -50);
            Assert.IsFalse(result);
        }
    }

    [TestClass]
    public class Test_GetMiddleCharacter
    {
        private Challenge challenge;

        [TestInitialize]
        public void Setup()
        {
            challenge = new Challenge();
        }

        [TestMethod]
        public void ValidInput_OddReturnsSingleCharacter()
        {
            string result = challenge.GetMiddleCharacter("Sam");
            Assert.AreEqual("a", result);
        }

        [TestMethod]
        public void ValidInput_EvenReturnsMultipleCharacters()
        {
            string result = challenge.GetMiddleCharacter("Andy");
            Assert.AreEqual("nd", result);
        }

        [TestMethod]
        public void InvalidInput_MultipleWordsReturnsInvalidMessage()
        {
            string result = challenge.GetMiddleCharacter("Sam Joyce");
            Assert.AreEqual("Invalid Input", result);
        }

        [TestMethod]
        public void InvalidInput_NoWordReturnsInvalidMessage()
        {
            string result = challenge.GetMiddleCharacter("");
            Assert.AreEqual("Invalid Input", result);
        }
    }

    [TestClass]
    public class Test_PrintMegaBytesAndKiloBytes
    {
        private Challenge challenge;

        [TestInitialize]
        public void Setup()
        {
            challenge = new Challenge();
        }

        [TestMethod]
        public void ValidInputs_Returns2MBand172KB()
        {
            String result = challenge.PrintMegaBytesAndKiloBytes(2220);
            Assert.AreEqual("2220 KB = 2 MB and 172 KB", result);
        }

        [TestMethod]
        public void ValidInputs_Returns1MBand0KB()
        {
            String result = challenge.PrintMegaBytesAndKiloBytes(1024);
            Assert.AreEqual("1024 KB = 1 MB and 0 KB", result);
        }

        [TestMethod]
        public void ValidInputs_Returns0MBand500KB()
        {
            String result = challenge.PrintMegaBytesAndKiloBytes(500);
            Assert.AreEqual("500 KB = 0 MB and 500 KB", result);
        }

        [TestMethod]
        public void InvalidInputs_ReturnsInvalidMessage()
        {
            String result = challenge.PrintMegaBytesAndKiloBytes(-2220);
            Assert.AreEqual("Invalid value", result);
        }
    }

    [TestClass]
    public class Test_CalculateReturn
    {
        private Challenge challenge;

        [TestInitialize]
        public void Setup()
        {
            challenge = new Challenge();
        }

        [TestMethod]
        public void ValidInputs_ReturnGrowth10Years()
        {
            string result = challenge.CalculateReturn(1000, 10, 0.1);
            Assert.AreEqual("You now have " + 2594, result);
        }

        [TestMethod]
        public void InvalidInputs_InvestmentReturnInvestmentMessage()
        {
            string result = challenge.CalculateReturn(-1000, 10, 0.1);
            Assert.AreEqual("Invalid investment", result);
        }

        [TestMethod]
        public void InvalidInputs_YearsReturnYearsMessage()
        {
            string result = challenge.CalculateReturn(1000, -10, 0.1);
            Assert.AreEqual("Invalid years", result);
        }

        [TestMethod]
        public void InvalidInputs_InterestReturnInterestMessage()
        {
            string interestToHigh = challenge.CalculateReturn(1000, 10, 1);
            Assert.AreEqual("Invalid rate of interest", interestToHigh);

            string interestToLow = challenge.CalculateReturn(1000, 10, -0.5);
            Assert.AreEqual("Invalid rate of interest", interestToLow);
        }
    } 
}
