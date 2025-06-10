using Library_System.Library_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System
{
    public class DVD : LibraryItem
    {
        // DVD properties
        public string Director { get; set; }
        public double Duration { get; set; } // Duration in hours

        // Constructor to initialize DVD properties
        public DVD(int id, string title, int yearPublished, string director, double duration)
            : base(id, title, yearPublished)
        {
            Director = director;
            Duration = duration;
        }

        // Override the method to show DVD details
        public override void DisplayInfo()
        {
            Console.WriteLine($"DVD - ID: {ID}, Title: {Title}, Year: {YearPublished}, Director: {Director}, Duration: {Duration} hrs");
        }
    }
}