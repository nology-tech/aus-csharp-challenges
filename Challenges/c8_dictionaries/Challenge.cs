using System;
using System.Collections.Generic;

namespace Challenges.c8_dictionaries
{
    public class Challenge
    {
        // -------------- FOUNDATION --------------

        ///
        /// <summary>
        ///     Return the title of the book with the given complete isbn.
        /// </summary>
        /// <param name="books"> dictionary of books and corresponding isbn </param>
        /// <param name="isbn"> given isbn string </param>
        /// <returns> string - title of book with given isbn </returns>
        /// 
        public string FilterByIsbn(Dictionary<string, string> books, string isbn)
        {
            throw new NotImplementedException();
        }
        ///
        /// <summary>
        ///     Return the isbn of the book with the given title.
        /// </summary>
        /// <param name="books"> dictionary of books and corresponding isbn </param>
        /// <param name="title"> given title string </param>
        /// <returns> string - isbn of book with given title </returns>
        /// 
        public string FilterByTitle(Dictionary<string, string> books, string title)
        {
            throw new NotImplementedException();
        }

        // -------------- INTERMEDIATE --------------

        /// <summary>
        ///     Given a list of books with titles and isbn codes, convert to Dictionary with isbn as key and title as value.
        /// </summary>
        ///
        /// @param bookList - List<Book> <param name="BookList"> List<Book> </param>
        ///
        /// 
        /// @return Dictionary<string isbn, string title> <returns> Dictionary<string isbn, string title> </returns>
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
        ///    You are trying to gather data analytics for your Youtube channel. You want to 
        ///    convert a list of this year's subscribers into a Dictionary.
        ///    Create a Dictionary of female subscribers, where the key is the subscriber's name.
        /// </summary>
        /// <param name="subscribers"> List of Subscriber Class </param>
        /// <returns> Dictionary<int age, string name> </returns>
        public Dictionary<string, int> FemaleSubscribers(List<Subscriber> subscribers)
            {
            throw new NotImplementedException();
            }

        // -------------- ADVANCED --------------

        ///
        /// <summary>
        ///    Using the Dictionary cipher, decode the code phrase and discover the secret! Return the secret phrase as a string. 
        /// </summary>
        /// <param name="codePhrase"> the encoded phrase to be translated </param>
        /// <param name="cipher"> the cipher with which to translate the phrase </param>
        /// <returns> string - translated code phrase </returns>
        public string DecodeTheSecretMessage(string codePhrase, Dictionary<string, string> cipher)
            {
            throw new NotImplementedException();
            }
    }
}
