using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System
{
    namespace Library_System
    {
        public abstract class LibraryItem
        {
            // Common properties for all library items
            public int ID { get; set; }
            public string Title { get; set; }
            public int YearPublished { get; set; }
            // Constructor to initialize common properties
            public LibraryItem(int id, string title, int yearPublished)
            {
                ID = id;
                Title = title;
                YearPublished = yearPublished;
            }
            // Abstract method to display item information
            public abstract void DisplayInfo();
        }
    }
}
