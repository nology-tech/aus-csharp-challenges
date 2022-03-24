using System.Collections.Generic;
using Challenges;
using Challenges.c9_forEach_and_linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    public class Test_FindByIsbnSnippet {

        private Challenge challenge;
        private Dictionary<string, string> books;
        private List<string> emptyList;
        private List<string> all;

        [TestInitialize]
        public void SetUp()
        {
            challenge = new Challenge();
            emptyList.Clear();
            all = new List<string>
            {
                "Macbeth",
                "A Midsummer Night's Dream",
                "Hamlet",
                "Othello",
                "King Lear"
            };

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
            List<string> result = challenge.FindByIsbnSnippet(books, "978-19283746");
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("King Lear", result[0]);
        }

        [TestMethod]
        public void ValidInput_Macbeth()
        {
            List<string> result = challenge.FindByIsbnSnippet(books, "978-19283756");
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("Macbeth", result[0]);
        }

        [TestMethod]
        public void ValidInput_Hamlet()
        {
            List<string> result = challenge.FindByIsbnSnippet(books, "965-97887998");
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("Hamlet", result[0]);
        }

        [TestMethod]
        public void ValidInput_ReturnsMultiple()
        {
            List<string> expected = new List<string>
            {
                "Macbeth",
                "A Midsummer Night's Dream",
                "King Lear"
            };
            List<string> result = challenge.FindByIsbnSnippet(books, "978");
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ReturnsEmptyArrayList()
        {
            List<string> result = challenge.FindByIsbnSnippet(books, "");
            Assert.AreEqual(all, result);
        }

        [TestMethod]
        public void IncompleteIsbn_ReturnsEmptyArrayList()
        {
            List<string> result = challenge.FindByIsbnSnippet(books, "9");
            Assert.AreEqual(all, result);
        }

        [TestMethod]
        public void InvalidIsbn_ReturnsEmptyArrayList()
        {
            List<string> result = challenge.FindByIsbnSnippet(books, "999-99999999");
            Assert.AreEqual(emptyList, result);
        }

        [TestMethod]
        public void NonExistantIsbn_ReturnsEmptyList()
        {
            List<string> result = challenge.FindByIsbnSnippet(books, "abcdefghij");
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
        Subscriber dave = new Subscriber("dave", "male", 25, 1647471725); // Mar 17
        Subscriber sandra = new Subscriber("Sandra", "female", 25, 1645988460); //Feb 28 
        Subscriber michaela = new Subscriber("Michaela", "female", 23, 1647813765); // Mar 21
        Subscriber agnes = new Subscriber("Agnes", "female", 39, 1647903725); // Mar 22
        Subscriber will = new Subscriber("Will", "male", 40, 1645052525); // Feb 17
        Subscriber hubert = new Subscriber("Hubert", "male", 33, 1643576703); // Jan 31
        Subscriber steve = new Subscriber("Steve", "male", 24, 1643673788); // Feb 01
        Subscriber cam = new Subscriber("Cam", "male", 55, 1646352188); // Mar 04
        Subscriber jane = new Subscriber("Jane", "female", 25, 1641783600); //Jan 10 
        Subscriber linda = new Subscriber("Linda", "female", 67, 1647111660); // Mar 13

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
        Assert.AreEqual(4, result.Count);
        Assert.AreEqual("Sandra", result[0].Name);
        Assert.AreEqual("Michaela", result[1].Name);
        Assert.AreEqual("Agnes", result[2].Name);
        Assert.AreEqual("Jane", result[3].Name);
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
        private string message2;

        [TestInitialize]
        public void SetUp()
        {
            challenge = new Challenge();
            message = "Beware the Ides of March";
            message2 = "If he had anything confidential to say, he wrote it in cipher, that is," +
                " by so changing the order of the letters of the alphabet, that not a word could be made out.";
        }

        [TestMethod]
        public void ReturnsCorrectEncryption()
        {
            string result = challenge.Encryption(message);
            Assert.AreEqual("orjner gur vqrf bs znepu", result);
            Assert.AreNotEqual("orjnergurvqrfbsznepu", result);
            Assert.AreNotEqual("Orjner gur Vqrf bs Znepu", result);
        }

        [TestMethod]
        public void ReturnsCorrectEncryptionPunctuation()
        {
            string result = challenge.Encryption(message2);
            Assert.AreEqual("Vs ur unq nalguvat pbasvqragvny gb fnl, ur jebgr vg va pvcure, gung vf, ol fb punatvat gur beqre bs gur yrggref bs gur nycunorg, gung abg n jbeq pbhyq or znqr bhg."
                , result);
        }


        [TestMethod]
        public void EmptyEncryptionReturnsEmpty()
        {
            string result = challenge.Encryption(message2);
            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void ValidEncryptionWithNumbersReturnsNumbersUnchanged()
        {
            string result = challenge.Encryption("99 is 1 less than 100.");
            Assert.AreEqual("99 vf 1 yrff guna 100.", result);
        }
    }
}
