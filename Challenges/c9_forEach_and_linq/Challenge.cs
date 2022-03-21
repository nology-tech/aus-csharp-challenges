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
         /// <param name="title"> title string with which we are searching </param>
         /// <returns>
         ///    isbn code that matches corresponding title
         ///    IF NULL - empty string 
         /// </returns>
        public string FindIsbnByTitle(Dictionary<string, string> books, string title)
        {
            return "";
        }

        ///
         /// <summary>
         ///    USE LINQ to return only the books with isbn codes that begin with '978'
         /// </summary>
         /// <param name="books"> dictionary of books and corresponding isbn </param>
         /// <param name="isbn"> String snippet of isbn </param>
         /// <returns>
         ///    new list of only books whose isbn contains '978-1' for example
         ///    if invalid isbn - return empty list
         /// </returns>
        public List<string> FilterByIsbnSnippet(Dictionary<string, string> books, string isbn)
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
        ///     You are trying to gather data analytics for a weekly publication. You want to 
        ///     know how many women under the age of 40 have subscribed to your service in
        ///     the last week. USE LINQ.
        /// </summary>
        /// <param name="subscribers">  List<Subscribers> - a list of the latest total subscribers </param>
        /// <returns>
        ///     new list of only subscribers whose gender = female, and 20 <= age <= 40
        /// </returns>
        public List<Subscriber> WeeklyFemaleSubscribers(List<Subscriber> subscribers)
        {
            return new List<Subscriber>();
        }
    }
}
