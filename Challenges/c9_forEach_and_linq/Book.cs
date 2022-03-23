using System;
namespace Challenges.c9_forEach_and_linq
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

