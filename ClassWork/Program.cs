using System;

namespace ClassWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cd = Console.ReadLine();
            Book book = new Book("Kimyager", " paulo coelho", 200, cd);
            Console.WriteLine(book.code(cd));
            Console.WriteLine("\n................\n");
            book.Showinfo();
            
           
        }
    }
}
