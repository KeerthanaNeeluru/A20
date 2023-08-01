using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A20
{
    
    public class Library
    {
        static List<Book> books;

        public Library()
        {
            books= new List<Book>();
        }
        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine("Book Added ");
        }
        public void ViewAllBooks()
        {
            foreach(Book book in books)
            {
                Console.WriteLine(book);
            }
        }
        public void SearchBookById(int Id)
        {
            Book book = books.Find(b => b.BookID == Id);
            if(book!=null)
            {
                Console.WriteLine("Book Found");
                Console.WriteLine(book);
            }
            else
            {
                Console.WriteLine("Book not found");
            }
        }
        public void SearchBookByName(string t)
        {
            Book book = books.Find(b => b.Title.ToLower().Contains(t.ToLower()) );
            if (book != null)
            {
                Console.WriteLine("Book Found");
                Console.WriteLine(book);
            }
            else
            {
                Console.WriteLine("Book not found");
            }
        }

        //Addbook,viewallbooks,searchbybookid,searchbybookname


    }
}
