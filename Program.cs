using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace Address_Book
{

    internal class Program
    {
        static void Main(string[] args)
        {
            AddressBook addressBook = new AddressBook();

            Console.WriteLine(" Welcome to AddressBookMenu:");
            Console.WriteLine("1. Add New Contact");

            Console.WriteLine("2. Exit");

            Console.Write("Enter your choice (1-2): ");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    // Add a new contact
                    addressBook.AddContact();
                    break;

                case "2":
                    // Exit the program
                    Console.WriteLine("Exiting the program. Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option (1-5).");
                    break;
            }

        }
    }
}