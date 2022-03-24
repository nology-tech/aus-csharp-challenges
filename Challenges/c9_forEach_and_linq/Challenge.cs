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
        ///    isbn codes. Use LINQ to find the isbn codes that correspond to the given title string.
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
        public List<string> FindByIsbnSnippet(Dictionary<string, string> books, string isbnSnippet)
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
        ///     the month of March. USE LINQ.
        ///
        ///     NOTE: The DateSubscribed attribute is represented as a long - Unix Timestamp
        ///     You can read more about Unix Time here: https://en.wikipedia.org/wiki/Unix_time
        ///     For the subscriber to have subscribed in March, their timestamp would have to be between
        ///     unix time Mar 1 2022 and unix time Mar 31 2022.
        /// </summary>
        /// <param name="subscribers">  List<Subscribers> - a list of the latest total subscribers </param>
        /// <returns>
        ///     new list of female subscribers under forty and who subscribed in the month of March
        /// </returns>
        public List<Subscriber> WeeklyFemaleSubscribers(List<Subscriber> subscribers)
        {
            return new List<Subscriber>();
        }


        // -------------- ADVANCED --------------
        // waiting for Aidan's tender touch 
    }
}