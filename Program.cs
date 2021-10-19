using System;

namespace ContactConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from the Console PhoneBook app");
            Console.WriteLine("Select Option");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Display contact by number");
            Console.WriteLine("3. View all contacts");
            Console.WriteLine("4. Search contacts");
            Console.WriteLine("5. Press 'x' to exit");

            var userInput = Console.ReadLine();

            var phoneBook = new PhoneBook();

            while (true)
            {

                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Contact Name:");
                        var name = Console.ReadLine();
                        Console.WriteLine("Contact Number");
                        var number = Console.ReadLine();

                        var newContact = new Contact(name, number);
                        phoneBook.AddContact(newContact);
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("Console number to search:");
                        var searchNumber = Console.ReadLine();
                        phoneBook.DisplayContact(searchNumber);
                        break;

                    case "3":
                        Console.Clear();
                        phoneBook.DisplayAllContact();
                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("Name search phrase");
                        var searchPhrase = Console.ReadLine();

                        phoneBook.DisplayMatchingContact(searchPhrase);
                        break;

                    case "x":
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Select valid operation");
                        break;
                }

                Console.WriteLine("Select operation");
                userInput = Console.ReadLine();
            }
        }
    }
}
