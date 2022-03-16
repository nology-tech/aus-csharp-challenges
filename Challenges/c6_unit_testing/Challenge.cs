using System;
using System.Linq;
using System.Text;

namespace Challenges.c6_unit_testing
{
    public class Challenge
    {
     

            // -------------- Foundation  --------------

            /// <summary>
            ///     Inside ChallengeTest.cs, write "positive" tests for the following function
            /// </summary>
            /// <param name="sentence"></param>
            /// <returns> the number of words in a sentence</returns>
        public int GetWordCount(string sentence)
            {
                string[] split = sentence.Split(" ");
                int numberOfWords = split.Length;
                return numberOfWords;
            }

             /// <summary>
             ///    Inside ChallengeTest.cs, write "positive" tests for the following function
             /// </summary>
             /// <param name="word"></param>
             /// <returns></returns>
        public bool IsPalindrome(string word)
        {
            return word.SequenceEqual(word.Reverse());

        }

            // -------------- Intermediate  --------------

            ///
            /// <summary>
            ///     Inside ChallengeTest.cs, write "positive" & "negative" tests for the following function
            /// </summary>
            /// <param name="firstName"></param>
            /// <param name="lastName"></param>
            /// <returns> full name </returns>
        public string GetFullName(string firstName, string lastName)
            {
              
                return firstName + " " + lastName;
            }


            ///
            /// Extra Challenges for early finishers.. Write negative tests for the first two methods :)
            /// Think what code might need to be altered.
            ///

        }
    }

