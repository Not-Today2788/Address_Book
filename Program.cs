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

            while (true)
            {
                Console.WriteLine(" AddressBookMenu:");
                Console.WriteLine("1. Add New Contact");
                Console.WriteLine("2. Edit Existing Contact");
                Console.WriteLine("3. Delete Contact");
                Console.WriteLine("4. Display All Contacts");

                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice (1-5): ");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        // Add a new contact
                        addressBook.AddContact();
                        break;

                    

                    case "2":
                        // Edit a contact
                        string editEmail = GetUserInput("Enter Email of the contact to edit");
                        if (addressBook.DoesEmailExist(editEmail))
                        {
                            addressBook.EditContact(editEmail);
                        }
                        else
                        {
                            Console.WriteLine("No contact found with the provided email. Contact not edited.");
                            Console.WriteLine("Press Enter to continue...");
                            Console.ReadLine();
                        }
                        break;

                    case "3":
                        // Delete a contact
                        string deleteEmail = GetUserInput("Enter Email of the contact to delete");
                        addressBook.DeleteContact(deleteEmail);
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();
                        break;

                    case "4":
                        // Display all contacts
                        Console.WriteLine("\nAll Contacts:");
                        addressBook.DisplayContacts();
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();
                        break;

                    case "5":
                        // Exit the program
                        Console.WriteLine("Exiting the program. Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option (1-5).");
                        break;
                }

                Console.Clear(); // Clear console for better readability
            }
        }

        static string GetUserInput(string prompt)
        {
            Console.Write($"{prompt}: ");
            return Console.ReadLine();
        }
    }
}