using Library_System.Library_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System
{
    public class Magazine : LibraryItem
    {
        // Magazine properties
        public int IssueNumber { get; set; }
        public string Month { get; set; }
        // Constructor to initialize Magazine properties
        public Magazine(int id, string title, int yearPublished, int issueNumber, string month)
            : base(id, title, yearPublished)
        {
            IssueNumber = issueNumber;
            Month = month;
        }
         // Override the method to show Magazine details
        public override void DisplayInfo()
        {
            Console.WriteLine($"Magazine - ID: {ID}, Title: {Title}, Year: {YearPublished}, Issue: {IssueNumber}, Month: {Month}");
        }
    }
}