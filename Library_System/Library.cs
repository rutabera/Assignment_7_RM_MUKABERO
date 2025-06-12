using Library_System.Library_System;
using System;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System
{
    public class Library
    {// This class manages a collection of library items (books, DVDs, etc.).
        private List<LibraryItem> items = new List<LibraryItem>();

        public void AddItem(LibraryItem item) => items.Add(item);
        // This method adds a new item to the library collection
        public void RemoveItem(int id)
        {
            var item = items.FirstOrDefault(x => x.ID == id);
            if (item != null)
            {
                items.Remove(item);
                Console.WriteLine("Item removed successfully.");
            }
            else
            {
                Console.WriteLine("Item not found.");
            }
        }
        // This method removes an item from the library collection by its ID
        public void SearchItem(int id)
        {
            var item = items.FirstOrDefault(x => x.ID == id);
            if (item != null)
            {
                item.DisplayInfo();
            }
            else
            {
                Console.WriteLine("Item not found.");
            }
        }
        // This method searches for an item in the library collection by its ID and displays its information
        public void DisplayAllItems()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("No items in the library.");
                return;
            }

            foreach (var item in items)
            {
                item.DisplayInfo();
            }
        }
    }
}