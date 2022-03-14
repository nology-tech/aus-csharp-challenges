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
    }
}
