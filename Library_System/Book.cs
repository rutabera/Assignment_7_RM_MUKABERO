using Library_System.Library_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System
{
    public class Book : LibraryItem
    {
        // Book properties
        public string Author { get; set; }
        public string Genre { get; set; }

        // Constructor to initialize Book properties
        public Book(int id, string title, int yearPublished, string author, string genre)
            : base(id, title, yearPublished)
        {
            Author = author;
            Genre = genre;
        }
        // Override the method to show Book details
        public override void DisplayInfo()
        {
            Console.WriteLine($"Book - ID: {ID}, Title: {Title}, Year: {YearPublished}, Author: {Author}, Genre: {Genre}");
        }
    }
}