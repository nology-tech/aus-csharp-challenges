using System;
using System.Collections.Generic;


namespace Challenges.c9_forEach_and_linq
{
    public class Challenge
    {
        // -------------- FOUNDATION --------------

        ///
        /// <summary>
        ///    You are given a Dictionary of book titles and their corresponding
        ///    isbn codes. Use LINQ to find the isbn codes that corresponds to the given title String.
        /// </summary>
        /// <param name="books"> - {"978-19283746" = "Macbeth"
        ///                    "978-99112288" = "King Lear"
        ///                    "965-99911128" = "A Midsummer Night's Dream"
        ///                    "965-97887998" = "Hamlet"
        ///                    "954-12345678" = "Othello"}</param>
        /// <param name="title"> string - snippet of title by which we are filtering</param>
        /// <returns>
        ///    new list of isbn codes that matches corresponding title
        ///    IF INVALID - return empty list
        /// </returns>
        public List<string> FilterIsbnByTitleSnippet(Dictionary<string, string> books, string titleSnippet)
        {
            throw new Exception();
        }

        ///
        /// <summary>
        ///    USE LINQ to return only the books with isbn codes that begin with '978'
        /// </summary>
        /// <param name="books"> dictionary of books and corresponding isbn </param>
        /// <param name="isbn"> String snippet of isbn </param>
        /// <returns>
        ///    new list of only books whose isbn contains '978-1' for example
        ///    IF INVALID - return empty list
        /// </returns>
        public List<string> FilterByIsbnSnippet(Dictionary<string, string> books, string isbnSnippet)
        {
            return new List<string>();
        }

        ///
        /// <summary>
        ///    USE LINQ to sort the list of integers and remove all odd number from the collection
        /// </summary>
        /// <param name="numbers"> The list we are filtering </param>
        /// <returns> List of sorted even numbers </returns>
        public List<int> LinqSortAndRemoveOddNumbers(List<int> numbers)
        {
            return new List<int>();
        }

        // -------------- INTERMEDIATE --------------

        ///
        /// <summary>
        ///     You are trying to gather data analytics for your Youtube channel You want to 
        ///     know how many women under the age of 40 have subscribed to your channel in
        ///     the last week. USE LINQ.
        /// </summary>
        /// <param name="subscribers">  List<Subscribers> - a list of the latest total subscribers </param>
        /// <returns>
        ///     new list of female subscribers under forty 
        /// </returns>
        public List<Subscriber> WeeklyFemaleSubscribers(List<Subscriber> subscribers)
        {
            return new List<Subscriber>();
        }


        // -------------- ADVANCED --------------

        /// <summary>
        ///     Use LINQ to iterate over a given string and encrypt that messeage using a Caeser cipher.
        ///     Caesar ciphers shift every letter 13 places forward in the alphabet.
        ///     If the letter is shifted from Z, it will continue in a loop back to A.
        ///
        ///     Maintain the spacing of the original message, and lower the case of the string before encrypting. 
        ///     
        /// </summary>
        /// <param name="message">  string - message to be decrypted </param>
        /// <returns>
        ///     string - encrypted message
        /// </returns>
        ///

        public string Encryption(string message)
        {
            return "";
        }
    }
}