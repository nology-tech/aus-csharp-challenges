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
        private String title;
        private String title2;
        private String title3;

        [TestInitialize]
        public void SetUp()
        {
            challenge = new Challenge();


            title = "Macbeth";
            title2 = "A Midsummer Night's Dream";
            title3 = "Hamlet";

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
        public void ValidInputs_ReturnStrings()
        {
            Assert.AreEqual("978-19283756", challenge.FindIsbnByTitle(books, title));
            Assert.AreEqual("978-99112288", challenge.FindIsbnByTitle(books, title2));
            Assert.AreEqual("965-97887998", challenge.FindIsbnByTitle(books, title3));

        }

        [TestMethod]
        public void InvalidInputs_ReturnEmptyString()
        {
            Assert.AreEqual("", challenge.FindIsbnByTitle(books, "The Merchant of Venice"));
            Assert.AreEqual("", challenge.FindIsbnByTitle(books, "Romeo and Juliet"));
            Assert.AreEqual("", challenge.FindIsbnByTitle(books, "Twelfth Night"));

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
            List<String> result = challenge.FilterByIsbnSnippet(this.books, "978-19283746");
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("King Lear", result[0]);
        }

        [TestMethod]
        public void ValidInput_Macbeth()
        {
            List<string> result = challenge.FilterByIsbnSnippet(this.books, "978-19283756");
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("Macbeth", result[0]);
        }

        [TestMethod]
        public void ValidInput_Hamlet()
        {
            List<string> result = challenge.FilterByIsbnSnippet(this.books, "965-97887998");
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("Hamlet", result[0]);
        }

        [TestMethod]
        public void ReturnsEmptyArrayList()
        {
            List<string> result = challenge.FilterByIsbnSnippet(this.books, "");
            Assert.AreEqual(emptyList, result);
        }

        [TestMethod]
        public void IncompleteIsbn_ReturnsEmptyArrayList()
        {
            List<string> result = challenge.FilterByIsbnSnippet(this.books, "9");
            Assert.AreEqual(emptyList, result);
        }

        [TestMethod]
        public void NonexistantIsbn_ReturnsEmptyArrayList()
        {
            List<string> result = challenge.FilterByIsbnSnippet(this.books, "999-99999999");
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
            List<int> result = challenge.LinqSortAndRemoveOddNumbers(this.data);
            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(10, result[0]);
            Assert.AreEqual(12, result[1]);
            Assert.AreEqual(32, result[2]);

        }

        [TestMethod]
        public void InvalidInput()
        {
            List<int> result = challenge.LinqSortAndRemoveOddNumbers(this.data);
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
    { dave,
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
        List<Subscriber> result = challenge.WeeklyFemaleSubscribers(this.subscribers);
        Assert.AreEqual(3, result.Count);
        Assert.AreEqual("Sandra", result[0].GetName());
        Assert.AreEqual("Michaela", result[1].GetName());
        Assert.AreEqual("Jane", result[2].GetName());

    }

    [TestMethod]
    public void ValidInput_ReturnsNonEmptyList()
    {
    List<Subscriber> result = challenge.WeeklyFemaleSubscribers(this.subscribers);
    int zero = 0;
    int size = result.Count;
    Assert.AreNotEqual(zero, size);

    }

    [TestMethod]
    public void ValidInput_ReturnsNoMen()
    {
    List<Subscriber> result = challenge.WeeklyFemaleSubscribers(this.subscribers);
    List<Subscriber> men = subscribers.FindAll(s => s.GetGender() == "male");
    Assert.IsNull(result.Find(sub => sub.GetGender() == "male"));

    }

    [TestMethod]
    public void ValidInput_ReturnsNoOneOverForty()
    {
    List<Subscriber> result = challenge.WeeklyFemaleSubscribers(this.subscribers);
    Assert.IsNull(result.Find(sub => sub.GetAge() > 40));

    }
}