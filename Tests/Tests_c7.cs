using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenges.c7_collections;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class Tests_CsvToList
    {

        private Challenge challenge;

        [TestInitialize]
        public void SetUp()
        {
            challenge = new Challenge();
        }

        [TestMethod]
        public void ValidCsv_ReturnsList()
        {
            List<string> result = challenge.CsvToList("Andy,Sam,Bex,Ollie");
            Assert.AreEqual(4, result.Count);
            Assert.AreEqual("Andy", result[0]);
            Assert.AreEqual("Sam", result[1]);
            Assert.AreEqual("Bex", result[2]);
            Assert.AreEqual("Ollie", result[3]);
        }
    }
    [TestClass]
    public class Test_GetSlicedArray
    {

        private Challenge challenge;
        private List<string> data;


        [TestInitialize]
        public void SetUp()
        {
            challenge = new Challenge();
            data = new List<string>
            {
                "Andy",
                "Sam",
                "Bex",
                "Ollie"
            };

        }

        [TestMethod]
        public void ValidInputs_ReturnsSubList()
        {

            List<String> result = challenge.GetSlicedArray(this.data, 1, 3);
            Assert.AreEqual("Sam", result[0]);
            Assert.AreEqual("Ollie", result[2]);
            Assert.AreEqual(3, result.Count);
        }

        [TestMethod]
        public void InvalidInputs_ReturnsSubList()
        {

            List<string> result = challenge.GetSlicedArray(this.data, 4, 6);
            Assert.AreEqual(0, result.Count);
        }
    }

    [TestClass]
    public class Test_SwapElements
    {

        private Challenge challenge;
        private List<string> data;


        [TestInitialize]
        public void SetUp()
        {
            challenge = new Challenge();
            data = new List<string>
            {
                "Andy",
                "Sam",
                "Bex",
                "Ollie"
            };

        }



        [TestMethod]
        public void ValidInputs_ReturnsSwappedArray()
        {
            List<string> result = challenge.SwapElements(this.data, 0, 3);
            Assert.AreEqual("Ollie", result[0]);
            Assert.AreEqual("Andy", result[3]);
            Assert.AreEqual(4, result.Count);
        }
    }

    [TestClass]
    public class Test_RemoveOddNumbers
    {

        private Challenge challenge;
        private List<int> data2;

        [TestInitialize]
        public void SetUp()
        {
            challenge = new Challenge();

            data2 = new List<int>();
            data2.Add(3);
            data2.Add(5);
            data2.Add(10);
            data2.Add(12);
        }


        [TestMethod]
        public void ValidInput_ReturnsEvenNumbers()
        {
            List<int> result = challenge.RemoveOddNumbers(this.data2);
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(12, result[1]);
        }
    }

    [TestClass]
    public class Test_GetUniqueItems
    {

        private Challenge challenge;
        private List<string> data;

        [TestInitialize]
        public void SetUp()
        {
            challenge = new Challenge();
            data = new List<string>
            {
                "Andy",
                "Sam",
                "Bex",
                "Ollie"
            };

        }

        [TestMethod]
        public void ValidInput_ReturnsDistinctList()
        {
            this.data.Add("Andy");
            this.data.Add("Ollie");
            List<string> result = challenge.GetUniqueItems(this.data);
            Assert.AreEqual(4, result.Count);
            Assert.AreEqual("Andy", result[0]);
            Assert.AreEqual("Sam", result[1]);
            Assert.AreEqual("Bex", result[2]);
            Assert.AreEqual("Ollie", result[3]);
        }
    }

    [TestClass]
    public class Test_FindItems
    {

        private Challenge challenge;
        private List<int> testData;

        [TestInitialize]
        public void SetUp()
        {
            List<int> testData = new List<int>
            {
                3,
                5,
                10,
                12,
                20,
                36,
                72
            };
        }

        [TestMethod]
        public void ValidArray_ReturnsIndexOfSearchItem()
        {


            int result = challenge.FindItem(testData, 12);
            Assert.AreEqual(1, result);

            result = challenge.FindItem(testData, 36);
            Assert.AreEqual(2, result);

            result = challenge.FindItem(testData, 5);
            Assert.AreEqual(2, result);

            result = challenge.FindItem(testData, 20);
            Assert.AreEqual(3, result);

            result = challenge.FindItem(testData, 3);
            Assert.AreEqual(3, result);
        }
    }

}