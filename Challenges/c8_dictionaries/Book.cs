using System;
namespace Challenges.c8_dictionaries
{
    public class Book
    {
        public Book() { }

        private string isbn;
        private string title;

        public Book(string isbn, string title)
        {
            SetIsbn(isbn);
            SetTitle(title);
        }

        public string GetIsbn()
        {
            return isbn;
        }

        public void SetIsbn(string isbn)
        {
            this.isbn = isbn;
        }

        public string GetTitle()
        {
             return title;
        }

        public void SetTitle(string title)
        {
            this.title = title;
        }
    }
}

