using System;

namespace Library_System
{
    class Program
    {
        /// Base class for library items
        static Library library = new Library();
        /// Main method to run the library system
        static void Main()
        {
            while (true)
            {
                // Display the menu options
                Console.WriteLine("\nLibrary System Menu:");
                Console.WriteLine("1. Add Item");
                Console.WriteLine("2. Remove Item");
                Console.WriteLine("3. Search Item");
                Console.WriteLine("4. Display All Items");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                try
                {
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            AddItem();
                            break;
                        case 2:
                            RemoveItem();
                            break;
                        case 3:
                            SearchItem();
                            break;
                        case 4:
                            library.DisplayAllItems();
                            break;
                        case 5:
                            Console.WriteLine("Exiting system. Goodbye!");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Unexpected error: {ex.Message}");
                }
            }
        }

        static void AddItem()
        {
            try
            {
                Console.Write("Enter item type (Book/Magazine/DVD): ");
                string type = Console.ReadLine().ToLower();
                Console.Write("Enter ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Enter Title: ");
                string title = Console.ReadLine();
                Console.Write("Enter Year Published: ");
                int year = int.Parse(Console.ReadLine());

                switch (type)
                {
                    case "book":
                        Console.Write("Enter Author: ");
                        string author = Console.ReadLine();
                        Console.Write("Enter Genre: ");
                        string genre = Console.ReadLine();
                        library.AddItem(new Book(id, title, year, author, genre));
                        break;

                    case "magazine":
                        Console.Write("Enter Issue Number: ");
                        int issueNumber = int.Parse(Console.ReadLine());
                        Console.Write("Enter Month: ");
                        string month = Console.ReadLine();
                        library.AddItem(new Magazine(id, title, year, issueNumber, month));
                        break;

                    case "dvd":
                        Console.Write("Enter Director: ");
                        string director = Console.ReadLine();
                        Console.Write("Enter Duration (hours): ");
                        double duration = double.Parse(Console.ReadLine());
                        library.AddItem(new DVD(id, title, year, director, duration));
                        break;

                    default:
                        Console.WriteLine("Invalid item type.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format. Please enter correct values.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }

        static void RemoveItem()
        {
            try
            // Prompt the user for an ID to remove an item
            {
                Console.Write("Enter ID to remove: ");
                int id = int.Parse(Console.ReadLine());
                library.RemoveItem(id);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. ID must be a number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }

        static void SearchItem()
        {
            // Prompt the user for an ID to search for an item
            try
            {
                Console.Write("Enter ID to search: ");
                int id = int.Parse(Console.ReadLine());
                library.SearchItem(id);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. ID must be a number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }
    }
}