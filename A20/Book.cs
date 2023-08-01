using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A20
{
    public class Book
    {
        //BookID,Title,Author,Genre,IsAvailable
        public int BookID {  get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public bool IsAvailable { get; set; }
        public Book(int bookID, string title, string author, string genre,bool isAvailable)
        {
            BookID = bookID;
            Title = title;
            Author = author;
            Genre = genre;
            IsAvailable = isAvailable;
        }
        public override string ToString()
        {
            return $"BookID: {BookID}, Title: {Title}, Author: {Author},Genre: {Genre},IsAvailable : {(IsAvailable ? "Yes" : "No")} ";
        }
    }
}
