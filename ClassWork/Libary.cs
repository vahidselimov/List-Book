using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork
{
    internal class Libary
    {
        public List<Book> Books = new List<Book>();

        public List<Book>FindAllBooksByName(string value)
        {
            return Books.FindAll(book => book.Name.Contains(value));
        }
        public void RemoveAllBooksByNme(string value)
        {
            Books.RemoveAll(book => book.Name.Contains(value));
        }
        public List<Book> SearchBook(string value)
        {
            return Books.FindAll(book => book.Name.Contains(value) || book.AuthorName.Contains(value) || book.PageCount.ToString().Contains(value));
        }
        public List<Book> FindAllBooksByPageCountRange(int min,int max)
        {
            return Books.FindAll(book => book.PageCount >= min && book.PageCount <= max);
        }
        public void RemoveBookByCode(string value)
        {
            Book WantedBook = Books.Find(book => book.Code == value);
            if (WantedBook!=null)
            {
                Books.Remove(WantedBook);
            }
        }
    }
}
