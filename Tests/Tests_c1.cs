using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenges.c1_types_and_control_flow;

namespace Tests
{
    [TestClass]
    public class Test_FindLargestNumber
    {
        private Challenge challenge;

        [TestInitialize]
        public void Setup()
        {
            challenge = new Challenge();
        }

        [TestMethod]
        public void ValidIntegers_ReturnsLargest()
        {
            int result = challenge.FindLargestNumber(22, 25);
            Assert.AreEqual(25, result);
        }

        [TestMethod]
        public void EqualIntegers_ReturnsEqual()
        {
            int result = challenge.FindLargestNumber(22, 22);
            Assert.AreEqual(22, result);
        }

        [TestMethod]
        public void NegativeIntegers_ReturnsLargest()
        {
            int result = challenge.FindLargestNumber(-22, -100);
            Assert.AreEqual(-22, result);
        }
    }

    [TestClass]
    public class Test_FindLongestString
    {
        private Challenge challenge;

        [TestInitialize]
        public void Setup()
        {
            challenge = new Challenge();
        }

        [TestMethod]
        public void ValidStrings_ReturnsLongest()
        {
            string result = challenge.FindLongestString("Sam", "Andy");
            Assert.AreEqual("Andy", result);
        }

        [TestMethod]
        public void EqualStrings_ReturnsEqualMessage()
        {
            string result = challenge.FindLongestString("Cattywampus", "Cattywampus");
            Assert.AreEqual("These two are the same length!", result);
        }

        [TestMethod]
        public void ConcatenatedString_ReturnsLongest()
        {
            string result = challenge.FindLongestString("In my younger and more vulnerable years, my father gave me some advice"
                    + "that I've been mulling over ever since...", "YEET!");
            Assert.AreEqual("In my younger and more vulnerable years, my father gave me some advice"
                    + "that I've been mulling over ever since...", result);
        }
    }

    [TestClass]
    public class Test_GetDiscount
    {
        private Challenge challenge;

        [TestInitialize]
        public void Setup()
        {
            challenge = new Challenge();
        }

        [TestMethod]
        public void ValidInputs_ReturnCorrectDiscount()
        {
            double result = challenge.GetDiscount(100, 10);
            Assert.AreEqual(90, result);
        }

        [TestMethod]
        public void ValidInputs_ReturnCorrectDiscountWithDecimals()
        {
            double result = challenge.GetDiscount(27, 5);
            Assert.AreEqual(25.65, result);
        }

        [TestMethod]
        public void ValidInputs_OneHundredPercent_ReturnsZero()
        {
            double result = challenge.GetDiscount(100, 100);
            Assert.AreEqual(0, result);
        }
    }

    [TestClass]
    public class Test_CompareTwoNumbers
    {
        private Challenge challenge;

        [TestInitialize]
        public void Setup()
        {
            challenge = new Challenge();
        }

        [TestMethod]
        public void ValidInputsNotEqual_ReturnFalse()
        {
            bool result = challenge.CompareTwoNumbers(12.3333, 12.3343);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidInputsEqual_ReturnTrue()
        {
            bool result = challenge.CompareTwoNumbers(1.3333, 1.3333);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void InvalidInput_ReturnsFalse()
        {
            bool result = challenge.CompareTwoNumbers(1.3333, 1.2222);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void InvalidInputsNotDouble_ReturnFalse()
        {
            bool result = challenge.CompareTwoNumbers(1, 1.2222);
            Assert.IsFalse(result);
        }

    }

    [TestClass]
    public class Test_GetDayName
    {
        private Challenge challenge;

        [TestInitialize]
        public void Setup()
        {
            challenge = new Challenge();
        }

        [TestMethod]
        public void ValidInput_ReturnSunday()
        {
            string result = challenge.GetDayName(0);
            Assert.AreEqual("Sunday", result);
        }

        [TestMethod]
        public void ValidInput_ReturnMonday()
        {
            string result = challenge.GetDayName(1);
            Assert.AreEqual("Monday", result);
        }

        [TestMethod]
        public void ValidInput_ReturnTuesday()
        {
            string result = challenge.GetDayName(2);
            Assert.AreEqual("Tuesday", result);
        }

        [TestMethod]
        public void ValidInput_ReturnWednesday()
        {
            string result = challenge.GetDayName(3);
            Assert.AreEqual("Wednesday", result);
        }

        [TestMethod]
        public void ValidInput_ReturnThursday()
        {
            string result = challenge.GetDayName(4);
            Assert.AreEqual("Thursday", result);
        }

        [TestMethod]
        public void ValidInput_ReturnFriday()
        {
            string result = challenge.GetDayName(5);
            Assert.AreEqual("Friday", result);
        }

        [TestMethod]
        public void ValidInput_ReturnSaturday()
        {
            string result = challenge.GetDayName(6);
            Assert.AreEqual("Saturday", result);
        }

        [TestMethod]
        public void InvalidInput_ReturnsOutOfRange()
        {
            string result = challenge.GetDayName(9);
            Assert.AreEqual("Not a valid day range! The number needs to be from 0-6", result);
        }

    }

    [TestClass]
    public class Test_LeapYearChecker
    {
        private Challenge challenge;

        [TestInitialize]
        public void Setup()
        {
            challenge = new Challenge();
        }

        [TestMethod]
        public void ValidInput_ReturnsTrueDivisibleBy4()
        {
            bool result = challenge.LeapYearChecker(2016);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void InvalidInput_ReturnsFalseNotDivisibleBy4()
        {
            bool result = challenge.LeapYearChecker(2017);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidInput_ReturnsTrueDivisibleBy4And400()
        {
            bool result = challenge.LeapYearChecker(2000);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void InvalidInput_ReturnsFalseDivisibleBy4And100()
        {
            bool result = challenge.LeapYearChecker(2100);
            Assert.IsFalse(result);
        }
    }
}