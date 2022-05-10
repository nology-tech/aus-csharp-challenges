using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenges.c6_unit_testing;

namespace Tests
{
    public class Tests_c6
    {
  
        public class ChallengeTest
        {

            // 1 - Write a positive test below
            [TestClass]
            public class Test_GetWordCount
            {

                private Challenge challenge;

                [TestInitialize]
                public void SetUp()
                {
                    challenge = new Challenge();
                }
               
                [TestMethod]
                public void ValidSentence_ReturnsCorrectCount()
                {
                    // ... Write your code here
                    throw new NotImplementedException();
                }
            }
            // 2 - Write a positive test below
            [TestClass]
            public class Test_IsPalindrome
            {


                private Challenge challenge;

                [TestInitialize]
                public void SetUp()
                {
                    challenge = new Challenge();
                }
                [TestMethod]
                public void ValidPalindrome_ReturnsTrue()
                {
                    // ... Write your code here
                    throw new NotImplementedException();
                }
            }

            // 3 - Write a positive test below
            [TestClass]
            public class Test_GetFullName
            {

                private Challenge challenge;

                [TestInitialize]
                public void SetUp()
                {
                    challenge = new Challenge();
                }
                [TestMethod]
                public void ValidName_ReturnsCorrectFullName()
                {
                    // ... Write your code here
                    throw new NotImplementedException();
                }

                // 4 - Write a negative test below
                [TestMethod]
                public void NullLastName_ReturnsCorrectFullName()
                {
                    // ... Write your code here
                    //     NOTE: You might want to alter getFullName() for this
                    throw new NotImplementedException();
                }
            }
        }
    }
}

