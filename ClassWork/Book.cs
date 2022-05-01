using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork
{
    internal class Book
    {
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        //private string _code;
        private static int _count=10;
        public  int Count;
        public string Code;
        public Book(string name, string authorName, int pageCount, string Code)
        {

            _count++;
            Count = _count;
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
            
        }
        public string code(string cd)
        {
            if (cd == null)
            {

                return null;

            }
            return char.ToUpper(cd[0]) + char.ToUpper(cd[1]).ToString()+Book._count;
            
        }
       
        public void Showinfo()
        {
            Console.WriteLine($"Name:{Name},authorName:{AuthorName},Count{Count}");
        }
    }
}
