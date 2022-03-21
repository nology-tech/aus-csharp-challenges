using System;
using System.Collections.Generic;

namespace Challenges.c8_dictionaries
{
    public class Challenge
    {
        // -------------- FOUNDATION --------------

        /// <summary>
        ///     Given a list of books with titles and isbn codes, convert to Dictionary with isbn as key and title as value.
        /// </summary>
        ///
        /// @param bookList - List<Book> <param name="BookList"> List<Book> </param>
        ///
        /// 
        /// @return HashMap<String isbn, String title> <returns> Dictionary<string isbn, string title> </returns>
        ///
        public Dictionary<string, string> ConvertBookList(List<Book> BookList)
            {
            throw new NotImplementedException();
            }
        ///
        /// <summary>
        ///    Given a list of employees with salaries, convert to Dictionary with employee name as key and salary as value.
        /// </summary>
        /// <param name="Employees"> List<Employee> </param>
        /// <returns> Dictionary<string Employee.name, double Employee.salary> </returns>
        public Dictionary<string, double> ConvertEmployeesList(List<Employee> Employees)
            {
            throw new NotImplementedException();
            }
        ///
        /// <summary>
        ///     Iterate over the given Dictionary and return the title of the book with the given isbn code.
        /// </summary>
        /// <param name="books"> dictionary of books and corresponding isbn </param>
        /// <param name="isbn"> given isbn string </param>
        /// <returns> new list that contains isbn - if invalid return empty list </returns>
        public string FilterByIsbnSnippet(Dictionary<string, string> books, string isbn)
            {
            throw new NotImplementedException();
            }
        // -------------- INTERMEDIATE --------------

        ///
        /// <summary>
        ///    You are trying to gather data analytics for a weekly publication. You want to 
        ///    convert a list of subscribers into a HashMap.
        ///    Create a HashMap of female subscribers, where the key is the subscriber's name.
        /// </summary>
        /// <param name="subscribers"> List of Subscriber Class </param>
        /// <returns> Dictionary<int age, string name> </returns>
        public Dictionary<string, int> WeeklyFemaleSubscribers(List<Subscriber> subscribers)
            {
            throw new NotImplementedException();
            }

        // -------------- ADVANCED --------------

        ///
        /// <summary>
        ///    Using a Dictionary, create a binary translator for the first 5 letters of the alphabet. If the letter doesn't exist, return -1
        /// </summary>
        /// <param name="letter"> the letter to be translated</param>
        /// <returns> binary code translation </returns>
        public int GetBinaryTranslation(char letter)
            {
            throw new NotImplementedException();
            }
    }
}
