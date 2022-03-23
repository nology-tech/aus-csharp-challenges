using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenges.c9_forEach_and_linq;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class Tests_FindIsbnByTitle
    {
        private Challenge challenge;
        private Dictionary<string, string> books;
        private List<string> emptyList;


        [TestInitialize]
        public void SetUp()
        {
            challenge = new Challenge();

            emptyList.Clear();

            books = new Dictionary<string, string>
            {
                { "978-19283756", "Macbeth" },
                { "978-99112288", "A Midsummer Night's Dream" },
                { "965-97887998", "Hamlet" },
                { "954-12345678", "Othello" },
                { "978-19283746", "King Lear" }
            };



        }

        [TestMethod]
        public void ValidInput_ReturnsList()
        {
            List<string> expected = new List<string>() { "978-19283746" };
            List<string> result = challenge.FilterIsbnByTitleSnippet(books, "ing");
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void ValidInput_ReturnsListOfTwoIsbns()
        {
            List<string> expected = new List<string>() { "978-19283756", "954-12345678" };
            List<string> result = challenge.FilterIsbnByTitleSnippet(books, "th");
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void InvalidInputs_ReturnEmptyList()
        {
            Assert.AreEqual(emptyList, challenge.FilterIsbnByTitleSnippet(books, "xxx"));

        }
    }

    [TestClass]
    public class Test_FilterByIsbnSnippet {
        private Challenge challenge;
        private Dictionary<string, string> books;
        private List<string> emptyList;

        [TestInitialize]
        public void SetUp()
        {
            challenge = new Challenge();
            emptyList.Clear();
            books = new Dictionary<string, string>
            {
                { "978-19283756", "Macbeth" },
                { "978-99112288", "A Midsummer Night's Dream" },
                { "965-97887998", "Hamlet" },
                { "954-12345678", "Othello" },
                { "978-19283746", "King Lear" }
            };
        }

        [TestMethod]
        public void ValidInput_KingLear()
        {
            List<string> result = challenge.FilterByIsbnSnippet(books, "978-19283746");
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("King Lear", result[0]);
        }

        [TestMethod]
        public void ValidInput_Macbeth()
        {
            List<string> result = challenge.FilterByIsbnSnippet(books, "978-19283756");
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("Macbeth", result[0]);
        }

        [TestMethod]
        public void ValidInput_Hamlet()
        {
            List<string> result = challenge.FilterByIsbnSnippet(books, "965-97887998");
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("Hamlet", result[0]);
        }

        [TestMethod]
        public void ReturnsEmptyArrayList()
        {
            List<string> result = challenge.FilterByIsbnSnippet(books, "");
            Assert.AreEqual(emptyList, result);
        }

        [TestMethod]
        public void IncompleteIsbn_ReturnsEmptyArrayList()
        {
            List<string> result = challenge.FilterByIsbnSnippet(books, "9");
            Assert.AreEqual(emptyList, result);
        }

        [TestMethod]
        public void NonexistantIsbn_ReturnsEmptyArrayList()
        {
            List<string> result = challenge.FilterByIsbnSnippet(books, "999-99999999");
            Assert.AreEqual(emptyList, result);
        }
    }

    [TestClass]
    public class Test_LinqSortAndRemoveOddNumbers
    {
        private Challenge challenge;
        private List<int> data;


        [TestInitialize]
        public void SetUp()
        {
            challenge = new Challenge();


            data = new List<int>
            {
                3,
                55,
                10,
                12,
                -7,
                15,
                32
            };
        }

        [TestMethod]
        public void ValidInput_ReturnsEvenNumbers()
        {
            List<int> result = challenge.LinqSortAndRemoveOddNumbers(data);
            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(10, result[0]);
            Assert.AreEqual(12, result[1]);
            Assert.AreEqual(32, result[2]);

        }

        [TestMethod]
        public void InvalidInput()
        {
            List<int> result = challenge.LinqSortAndRemoveOddNumbers(data);
            Assert.AreNotEqual(0, result.Count);
            Assert.IsFalse(result.Contains(-7));
            Assert.IsFalse(result.Contains(55));
            Assert.IsFalse(result.Contains(15));

        }
    }
}

[TestClass]
public class Test_WeeklyFemaleSubscribers
{
    private Challenge challenge;
    private List<Subscriber> subscribers;



    [TestInitialize]
    public void SetUp()
    {
        challenge = new Challenge();
        Subscriber dave = new Subscriber("dave", "male", 25);
        Subscriber sandra = new Subscriber("Sandra", "female", 25);
        Subscriber michaela = new Subscriber("Michaela", "female", 23);
        Subscriber agnes = new Subscriber("Agnes", "female", 41);
        Subscriber will = new Subscriber("Will", "male", 40);
        Subscriber hubert = new Subscriber("Hubert", "male", 33);
        Subscriber steve = new Subscriber("Steve", "male", 24);
        Subscriber cam = new Subscriber("Cam", "male", 55);
        Subscriber jane = new Subscriber("Jane", "female", 25);
        Subscriber linda = new Subscriber("Linda", "female", 67);

        subscribers = new List<Subscriber>
    {
        dave,
        sandra,
        michaela,
        agnes,
        will,
        hubert,
        steve,
        cam,
        jane,
        linda
    };
    }

    [TestMethod]
    public void ValidInput()
    {
        List<Subscriber> result = challenge.WeeklyFemaleSubscribers(subscribers);
        Assert.AreEqual(3, result.Count);
        Assert.AreEqual("Sandra", result[0].Name);
        Assert.AreEqual("Michaela", result[1].Name);
        Assert.AreEqual("Jane", result[2].Name);

    }

    [TestMethod]
    public void ValidInput_ReturnsNonEmptyList()
    {
        List<Subscriber> result = challenge.WeeklyFemaleSubscribers(subscribers);
        int zero = 0;
        int size = result.Count;
        Assert.AreNotEqual(zero, size);

    }

    [TestMethod]
    public void ValidInput_ReturnsNoMen()
    {
        List<Subscriber> result = challenge.WeeklyFemaleSubscribers(subscribers);
        List<Subscriber> men = subscribers.FindAll(s => s.Gender == "male");
        Assert.IsNull(result.Find(sub => sub.Gender == "male"));

    }

    [TestMethod]
    public void ValidInput_ReturnsNoOneOverForty()
    {
        List<Subscriber> result = challenge.WeeklyFemaleSubscribers(subscribers);
        Assert.IsNull(result.Find(sub => sub.Age > 40));

    }

    [TestClass]
    public class Test_Encryption
    {
        private Challenge challenge;
        private string message;

        [TestInitialize]
        public void SetUp()
        {
            challenge = new Challenge();
            message = "Beware the Ides of March";
        }

        [TestMethod]
        public void ReturnsCorrectEncryption()
        {
            string result = challenge.Encryption(message);
            Assert.AreEqual("orjner gur vqrf bs znepu", result);
            Assert.AreNotEqual("orjnergurvqrfbsznepu", result);
            Assert.AreNotEqual("Orjner gur Vqrf bs Znepu", result);
        }
    }
}
