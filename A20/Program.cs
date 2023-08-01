using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            char ch;
            do
            {
                Console.WriteLine("Choose\n 1.Add a Book  2.View all books 3. Search by ID 4.search by Title  ");
                int menu=int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Enter BookId");
                        int id=int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Book Title");
                        string title=Console.ReadLine();
                        Console.WriteLine("Enter Author");
                        string author=Console.ReadLine();
                        Console.WriteLine("Enter Book Genre");
                        string genre=Console.ReadLine();
                        Console.WriteLine("Enter whether book is available or not");
                        bool isAvailable=bool.Parse(Console.ReadLine());
                        Book book=new Book(id, title, author, genre,isAvailable);
                        library.AddBook(book);
                        break;
                    case 2:
                        Console.WriteLine("\nBooks\n");
                        library.ViewAllBooks();
                        break;
                    case 3:
                        Console.WriteLine("Enter BookId to search");
                        int sid=int.Parse(Console.ReadLine());
                        library.SearchBookById(sid);
                        break;
                    case 4:
                        Console.WriteLine("Enter  Book Title to search");
                        string stitle=Console.ReadLine();
                        library.SearchBookByName(stitle);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        ch = 'n';
                        break;
                }
                Console.WriteLine("If you want to continue pres y");
                ch = char.Parse(Console.ReadLine().ToLower());
            } while (ch == 'y');
        }
    }
}
