﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenges.c8_dictionaries;
using System.Collections.Generic;

namespace Tests
{
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
    public class Test_FilterByIsbn {

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
            string result = challenge.FilterByIsbnSnippet(this.books, "978-19283746");
            Assert.AreEqual("King Lear", result);


        }

        [TestMethod]
        public void ValidInput_Macbeth()
        {
            string result = challenge.FilterByIsbnSnippet(this.books, "978-19283756");
            Assert.AreEqual("Macbeth", result);
        }

        [TestMethod]
        public void ValidInput_Hamlet()
        {
            string result = challenge.FilterByIsbnSnippet(this.books, "965-97887998");
            Assert.AreEqual("Hamlet", result);
        }

        [TestMethod]
        public void InvalidInput_ReturnsEmptyArrayList()
        {
            string result = challenge.FilterByIsbnSnippet(this.books, "");
            Assert.AreEqual(null, result);
        }

        [TestMethod]
        public void IncompleteIsbn_ReturnsEmptyArrayList()
        {
            string result = challenge.FilterByIsbnSnippet(this.books, "9");
            Assert.AreEqual(null, result);
        }

        [TestMethod]
        public void NonexistantIsbn_ReturnsEmptyArrayList()
        {
            string result = challenge.FilterByIsbnSnippet(this.books, "999-99999999");
            Assert.AreEqual(null, result);
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

            Subscriber dave = new Subscriber("Dave", "male", 25);
            Subscriber sandra = new Subscriber("Sandra", "female", 25);
            Subscriber michaela = new Subscriber("Michaela", "female", 23);
            Subscriber agnes = new Subscriber("Agnes", "female", 41);
            Subscriber will = new Subscriber("Will", "male", 40);
            Subscriber hubert = new Subscriber("Hubert", "male", 33);
            Subscriber steve = new Subscriber("Steve", "male", 24);
            Subscriber cam = new Subscriber("Cam", "male", 55);
            Subscriber jane = new Subscriber("Jane", "female", 25);
            Subscriber linda = new Subscriber("Linda", "female", 67);

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
            Dictionary<string, int> result = challenge.WeeklyFemaleSubscribers(this.subscribers);
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
            Dictionary<string, int> result = challenge.WeeklyFemaleSubscribers(this.subscribers);
            Assert.IsFalse(result.ContainsKey("Dave"));
            Assert.IsFalse(result.ContainsKey("Will"));
            Assert.IsFalse(result.ContainsKey("Hubert"));
            Assert.IsFalse(result.ContainsKey("Steve"));
            Assert.IsFalse(result.ContainsKey("Cam"));
        }

    }

    [TestClass]
    public class Test_GetBinaryTranslation
    {

        private Challenge challenge;

        [TestInitialize]
        public void SetUp()
        {
            challenge = new Challenge();
        }

        [TestMethod]
        public void ValidLetter_ReturnsBinary()
        {
            int result = challenge.GetBinaryTranslation('A');
            Assert.AreEqual(01100001, result);
            result = challenge.GetBinaryTranslation('a');
            Assert.AreEqual(01100001, result);
            result = challenge.GetBinaryTranslation('B');
            Assert.AreEqual(01100010, result);
            result = challenge.GetBinaryTranslation('C');
            Assert.AreEqual(01100011, result);
            result = challenge.GetBinaryTranslation('D');
            Assert.AreEqual(01100100, result);
            result = challenge.GetBinaryTranslation('E');
            Assert.AreEqual(01100101, result);
        }

        [TestMethod]
        public void InvalidLetters_ReturnsNegOne()
        {
            int result = challenge.GetBinaryTranslation('z');
            Assert.AreEqual(-1, (int)result);
            int result2 = challenge.GetBinaryTranslation('y');
            Assert.AreEqual(-1, (int)result2);
            int result4 = challenge.GetBinaryTranslation('q');
            Assert.AreEqual(-1, (int)result4);
            int result5 = challenge.GetBinaryTranslation('r');
            Assert.AreEqual(-1, (int)result5);
            int result6 = challenge.GetBinaryTranslation('s');
            Assert.AreEqual(-1, (int)result6);
            int result7 = challenge.GetBinaryTranslation('t');
            Assert.AreEqual(-1, (int)result7);
            int result8 = challenge.GetBinaryTranslation('9');
            Assert.AreEqual(-1, (int)result8);
        }

    }
}
