using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenges.c4_arrays_and_loops;

namespace Tests
{
    [TestClass]
    public class Test_GetFirstAndLast
    {

        private Challenge challenge;

        [TestInitialize]
        public void SetUp()
        {
            challenge = new Challenge();
        }

        [TestMethod]
        public void ValidNames_ReturnsOnlyFirstAndLastNames()
        {
            string[] result = challenge.GetFirstAndLast(new string[] { "Ollie", "Sam", "Bex" });
            CollectionAssert.AreEqual(new string[] { "Ollie", "Bex" }, result);

            string[] result2 = challenge.GetFirstAndLast(new string[] { "one", "two", "three", "four", "five", "six", "seven" });
            CollectionAssert.AreEqual(new string[] { "one", "seven" }, result2);
        }

        [TestMethod]
        public void InvalidNames_ReturnsEmptyArray()
        {
            string[] result = challenge.GetFirstAndLast(new string[0]);
            CollectionAssert.AreEqual(new string[0], result);
        }
    }

    [TestClass]
    public class Test_TotalAges
    {

        private Challenge challenge;

        [TestInitialize]
        public void SetUp()
        {
            challenge = new Challenge();
        }

        [TestMethod]
        public void ValidAges_ReturnsAmountOfAges()
        {
            int result = challenge.TotalAges(new int[] { 18, 25, 21, 40 });
            Assert.AreEqual(104, result);

            int result2 = challenge.TotalAges(new int[] { 5, 2 });
            Assert.AreEqual(7, result2);
        }

        [TestMethod]
        public void InvalidAges_ReturnsZero()
        {
            int result = challenge.TotalAges(new int[0]);
            Assert.AreEqual(0, result);
        }
    }

    [TestClass]
    public class Test_GetAmountOfOddNumbers
    {

        private Challenge challenge;

        [TestInitialize]
        public void SetUp()
        {
            challenge = new Challenge();
        }

        [TestMethod]
        public void ValidNumbers_ReturnsOnlyOddNumbers()
        {
            int result = challenge.GetAmountOfOddNumbers(new int[] { 5, 3, 8, 10, 1 });
            Assert.AreEqual(3, result);

            int result2 = challenge.GetAmountOfOddNumbers(new int[] { 1, 1, 3, 57, 59, 2, 2 });
            Assert.AreEqual(5, result2);

            int result3 = challenge.GetAmountOfOddNumbers(new int[] { 2, 4, 6, 8, 10, 12 });
            Assert.AreEqual(0, result3);
        }

        [TestMethod]
        public void InvalidNumbers_ReturnsZero()
        {
            int result = challenge.GetAmountOfOddNumbers(new int[0]);
            Assert.AreEqual(0, result);
        }
    }

    [TestClass]
    public class Test_GetRange
    {

        private Challenge challenge;

        [TestInitialize]
        public void SetUp()
        {
            challenge = new Challenge();
        }

        [TestMethod]
        public void ValidInput_ReturnsValidRange()
        {
            int[] result = challenge.GetRange(3, 6);
            int[] expectedResult = { 3, 4, 5, 6 };
            CollectionAssert.AreEqual(expectedResult, result);

            int[] result2 = challenge.GetRange(0, 4);
            int[] expectedResult2 = { 0, 1, 2, 3, 4 };
            CollectionAssert.AreEqual(expectedResult2, result2);
        }

        [TestMethod]
        public void InvalidInput_ReturnsEmptyArray()
        {
            int[] result = challenge.GetRange(10, 1);
            int[] expectedResult = { };
            CollectionAssert.AreEqual(expectedResult, result);
        }
    }

    [TestClass]
    public class Test_SwapNames
    {

        private Challenge challenge;

        [TestInitialize]
        public void SetUp()
        {
            challenge = new Challenge();
        }

        [TestMethod]
        public void ValidName_ReturnsSwappedNames()
        {
            string result = challenge.SwapNames("Andy Evans");
            Assert.AreEqual("Evans Andy", result);
            string result2 = challenge.SwapNames("Jane Doe Smith");
            Assert.AreEqual("Smith Doe Jane", result2);
        }

        [TestMethod]
        public void SingleName_ReturnsSingleName()
        {
            string result = challenge.SwapNames("Andy");
            Assert.AreEqual(result, "Andy");
        }
    }

    [TestClass]
    public class Test_IsHighestScore
    {

        private Challenge challenge;

        [TestInitialize]
        public void SetUp()
        {
            challenge = new Challenge();
        }

        [TestMethod]
        public void ValidHighScore_ReturnsCorrectValue()
        {
            bool result = challenge.IsHighestScore(new int[] { 3, 10, 2, 8 }, 12);
            Assert.IsTrue(result);
            bool result2 = challenge.IsHighestScore(new int[] { 3, 10, 2, 8 }, 2);
            Assert.IsFalse(result2);
        }

        [TestMethod]
        public void EmptyScores_ReturnsTrue()
        {
            bool result = challenge.IsHighestScore(new int[0], 12);
            Assert.IsTrue(result);
        }
    }

    [TestClass]
    public class Test_Sort
    {

        private Challenge challenge;

        [TestInitialize]
        public void SetUp()
        {
            challenge = new Challenge();
        }

        [TestMethod]
        public void UnsortedNumbers_ReturnSortedArray()
        {
            int[] result = challenge.Sort(new int[] { 5, 1, 4, 2, 8 });
            CollectionAssert.AreEqual(new int[] { 1, 2, 4, 5, 8 }, result);

            int[] result2 = challenge.Sort(new int[] { 10, 9, 8 });
            CollectionAssert.AreEqual(new int[] { 8, 9, 10 }, result2);
        }

        [TestMethod]
        public void SortedNumbers_ReturnSortedArray()
        {
            int[] result = challenge.Sort(new int[] { 1, 2, 4, 5, 8 });
            CollectionAssert.AreEqual(new int[] { 1, 2, 4, 5, 8 }, result);

            int[] result2 = challenge.Sort(new int[] { 8, 9, 10 });
            CollectionAssert.AreEqual(new int[] { 8, 9, 10 }, result2);
        }

        [TestMethod]
        public void InvalidInput_ReturnSortedArray()
        {
            int[] result = challenge.Sort(new int[0]);
            CollectionAssert.AreEqual(new int[0], result);
        }
    }
}