using System;
namespace Challenges.c8_dictionaries
{
    public class Book
    {

        private string _isbn;
        private string _title;

        public Book() { }

        public Book(string isbn, string title)
        {
            Isbn = isbn;
            Title = title;

        }

        public string Title { get; set; }
        public string Isbn { get; set; }

    }
}
