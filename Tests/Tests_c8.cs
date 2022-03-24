using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenges.c8_dictionaries;
using System.Collections.Generic;
using Challenges;

namespace Tests
{
    [TestClass]
    public class Test_FilterByIsbn
    {

        private Challenge challenge;
        private Dictionary<string, string> books;

        [TestInitialize]
        public void SetUp()
        {
            challenge = new Challenge();

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
            string result = challenge.FilterByIsbn(books, "978-19283746");
            Assert.AreEqual("King Lear", result);


        }

        [TestMethod]
        public void ValidInput_Macbeth()
        {
            string result = challenge.FilterByIsbn(books, "978-19283756");
            Assert.AreEqual("Macbeth", result);
        }

        [TestMethod]
        public void ValidInput_Hamlet()
        {
            string result = challenge.FilterByIsbn(books, "965-97887998");
            Assert.AreEqual("Hamlet", result);
        }

        [TestMethod]
        public void InvalidInput_ReturnsEmptyArrayList()
        {
            string result = challenge.FilterByIsbn(books, "");
            Assert.AreEqual(null, result);
        }

        [TestMethod]
        public void IncompleteIsbn_ReturnsEmptyArrayList()
        {
            string result = challenge.FilterByIsbn(this.books, "9");
            Assert.AreEqual(null, result);
        }

        [TestMethod]
        public void NonexistantIsbn_ReturnsEmptyArrayList()
        {
            string result = challenge.FilterByIsbn(this.books, "999-99999999");
            Assert.AreEqual(null, result);
        }
    }

    [TestClass]
    public class Test_FilterByTitle
    {

        private Challenge challenge;
        private Dictionary<string, string> books;

        [TestInitialize]
        public void SetUp()
        {
            challenge = new Challenge();

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
            string result = challenge.FilterByIsbn(books, "King Lear");
            Assert.AreEqual("978-19283746", result);


        }

        [TestMethod]
        public void ValidInput_Macbeth()
        {
            string result = challenge.FilterByIsbn(books, "Macbeth");
            Assert.AreEqual("978-19283756", result);
        }

        [TestMethod]
        public void ValidInput_Hamlet()
        {
            string result = challenge.FilterByIsbn(books, "Hamlet");
            Assert.AreEqual("965-97887998", result);
        }

        [TestMethod]
        public void InvalidInput_ReturnsEmptyArrayList()
        {
            string result = challenge.FilterByIsbn(books, "");
            Assert.AreEqual(null, result);
        }

        [TestMethod]
        public void IncompleteIsbn_ReturnsEmptyArrayList()
        {
            string result = challenge.FilterByIsbn(this.books, "Schmamlet");
            Assert.AreEqual(null, result);
        }

        [TestMethod]
        public void NonexistantIsbn_ReturnsEmptyArrayList()
        {
            string result = challenge.FilterByIsbn(this.books, "Schming Schmear");
            Assert.AreEqual(null, result);
        }
    }

    [TestClass]
    public class Test_ConvertBookList
    {

        private Challenge challenge;
        private List<Book> books;

        [TestInitialize]
        public void SetUp()
        {
            challenge = new Challenge();

            Book macbeth = new Book("978-589483545", "Macbeth");
            Book midsummer = new Book("978-19283756", "A Midsummer Night's Dream");
            Book kingLear = new Book("978-99112288", "King Lear");
            Book juliusC = new Book("978-589483", "Julius Caesar");
            Book hamlet = new Book("965-97887998", "Hamlet");

            books = new List<Book>
            {
                hamlet,
                midsummer,
                kingLear,
                macbeth,
                juliusC
            };

        }

       [TestMethod]
        public void ValidInputs()
        {
            Dictionary<string, string> result = challenge.ConvertBookList(books);
            Assert.IsTrue(result.GetType() == typeof(Dictionary<string, string>));
            Assert.IsNotNull(result);
            Assert.AreEqual(5, result.Count);
            Assert.AreEqual("Hamlet", result["965-97887998"]);
            Assert.AreEqual("Julius Caesar", result["978-589483"]);
            Assert.AreEqual("King Lear", result["978-99112288"]);
            Assert.AreEqual("A Midsummer Night's Dream", result["978-19283756"]);

        }


        [TestMethod]
        public void NonexistentValues()
        {
            Dictionary<string, string> result = challenge.ConvertBookList(books);
            Assert.AreEqual(null, result["9"]);
            Assert.AreEqual(null, result[""]);
            Assert.AreEqual(null, result["000000000000000"]);

        }

    }

    [TestClass]
    public class Test_ConvertEmployeesList
    {

        private Challenge challenge;
        private List<Employee> employees;

        [TestInitialize]
        public void SetUp()
        {
            challenge = new Challenge();

            challenge = new Challenge();
            Employee harvey = new Employee("Harvey Keeling", 50021.17);
            Employee shayna = new Employee("Shayna Herrera", 75000.57);
            Employee luke = new Employee("Luke Barclay", 100501.98);
            Employee claudia = new Employee("Claudia Baldwin", 45270.45);
            Employee allen = new Employee("Allen Peterson", 175496.93);
            Employee anna = new Employee("Anna Karenina", 10025500.74);
            Employee lester = new Employee("Lester Long", 67760.05);
            Employee billy = new Employee("Billy Pilgrim", 58850.10);
            Employee johnny = new Employee("Johnny Tremaine", 92000.15);
            Employee dick = new Employee("Dick Nixon", 88000.99);


            employees = new List<Employee>();
            employees.Add(harvey);
            employees.Add(shayna);
            employees.Add(luke);
            employees.Add(claudia);
            employees.Add(allen);
            employees.Add(anna);
            employees.Add(lester);
            employees.Add(billy);
            employees.Add(johnny);
            employees.Add(dick);
        }

        [TestMethod]
        public void ValidInput()
        {
            Dictionary<string, double> result = challenge.ConvertEmployeesList(this.employees);
            Assert.IsTrue(result.GetType() == typeof(Dictionary<string, double>));
            Assert.AreEqual(50021.17, result["Harvey Keeling"]);
            Assert.AreEqual(75000.57, result["Shayna Herrera"]);
            Assert.AreEqual(100501.98, result["Luke Barclay"]);
            Assert.AreEqual(45270.45, result["Claudia Baldwin"]);
        }

        [TestMethod]
        public void InvalidInput_ReturnsNull()
        {
            Dictionary<string, double> result = challenge.ConvertEmployeesList(this.employees);
            Assert.AreEqual(null, result[""]);
            Assert.AreEqual(null, result["Made-up Name"]);
            Assert.AreEqual(null, result[null]);

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
            Subscriber agnes = new Subscriber("Agnes", "female", 40, 1647903725); // Mar 22
            Subscriber will = new Subscriber("Will", "male", 40, 1645052525); // Feb 17
            Subscriber hubert = new Subscriber("Hubert", "male", 33, 1643576703); // Jan 31
            Subscriber steve = new Subscriber("Steve", "male", 24, 1643673788); // Feb 01
            Subscriber cam = new Subscriber("Cam", "male", 55, 1646352188); // Mar 04
            Subscriber jane = new Subscriber("Jane", "female", 25, 1641783600); //Jan 10 
            Subscriber linda = new Subscriber("Linda", "female", 67, 1647111660); // Mar 13

            subscribers = new List<Subscriber>();
            subscribers.Add(dave);
            subscribers.Add(michaela);
            subscribers.Add(agnes);
            subscribers.Add(will);
            subscribers.Add(hubert);
            subscribers.Add(steve);
            subscribers.Add(cam);
            subscribers.Add(jane);
            subscribers.Add(linda);
        }

        [TestMethod]
        public void ValidInput()
        {
            Dictionary<string, int> result = challenge.FemaleSubscribers(this.subscribers);
            Assert.IsNotNull(result);
            Assert.IsTrue(result.GetType() == typeof(Dictionary<string, int>));
            Assert.IsTrue(result.ContainsKey("Sandra"));
            Assert.IsTrue(result.ContainsKey("Michaela"));
            Assert.IsTrue(result.ContainsKey("Agnes"));
            Assert.IsTrue(result.ContainsKey("Jane"));
            Assert.IsTrue(result.ContainsKey("Linda"));
        }

        [TestMethod]
        public void ValidInput_ReturnsNoMen()
        {
            Dictionary<string, int> result = challenge.FemaleSubscribers(this.subscribers);
            Assert.IsFalse(result.ContainsKey("Dave"));
            Assert.IsFalse(result.ContainsKey("Will"));
            Assert.IsFalse(result.ContainsKey("Hubert"));
            Assert.IsFalse(result.ContainsKey("Steve"));
            Assert.IsFalse(result.ContainsKey("Cam"));
        }

    }

    [TestClass]
    public class Test_DecodeTheSecretMessage
    {

        private Challenge challenge;
        private Dictionary<string, string> cipher;
        private string codePhrase;
        private Dictionary<string, string> cipher2;
        private string codePhrase2;
        private Dictionary<string, string> cipher3;
        private string codePhrase3;

        [TestInitialize]
        public void SetUp()
        {
            challenge = new Challenge();
            cipher = new Dictionary<string, string>
            {
                {"x", "d"},
                {"q", "r"},
                {"g", "i"},
                {"r", "n"},
                {"h", "k"},
                {"l", "m"},
                {"p", "o"},
                {"a", "e"},
                {"w", "v"},
                {"e", "a"},
                {"b", "l"},
                {"v", "t"},
                {"g", "i"},
                {"y", "n"},

            };

            codePhrase = "xqgrh lpqa pwebvgya";

            cipher2 = new Dictionary<string, string>
            {
                {"x", "r" },
                {"c", "t"},
                {"y", "b" }
            };

            codePhrase2 = "xcy";

            cipher3 = new Dictionary<string, string>
            {
                {"c", "c" },
                {"a", "a"},
                {"t", "t" }
            };

            codePhrase3 = "cat";
        }

        [TestMethod]
        public void ValidInput_PrintsDecodedPhrase()
        {
            string result = challenge.DecodeTheSecretMessage(codePhrase, cipher);
            Assert.IsNotNull(result);
            Assert.AreEqual(result, "drink more ovaltine");
        }

        [TestMethod]
        public void ValidInput_Gibberish()
        {

            string result = challenge.DecodeTheSecretMessage(codePhrase2, cipher2);
            Assert.IsNotNull(result);
            Assert.AreEqual(result, "rtb");
        }

        [TestMethod]
        public void ValidInput_SameLetters()
        {

            string result = challenge.DecodeTheSecretMessage(codePhrase3, cipher3);
            Assert.IsNotNull(result);
            Assert.AreEqual(result, "cat");
        }
    }
}
