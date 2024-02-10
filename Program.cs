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
            
            MultiAddressBookClass MultiAddressBookObject= new MultiAddressBookClass();


            Console.WriteLine("Enter the name of Address Book you want to access? ");
            string bookName = Console.ReadLine();


            //AddressBook addressBook = new AddressBook();
            //MultiAddressBookObject[bookName] = addressBook; 


            
            AddressBook addressBook = new AddressBook(bookName, MultiAddressBookObject.get_MultiAddressBookDictionary());

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"The current AddressBook is: {bookName}\n");
                Console.WriteLine(" AddressBookMenu:");
                Console.WriteLine("1. Add New Contact");
                Console.WriteLine("2. Edit Existing Contact");
                Console.WriteLine("3. Delete Contact");
                Console.WriteLine("4. Display All Contacts");

                Console.WriteLine("5. Add a new AddressBook");
                Console.WriteLine("6. Display all the AddressBooks");
                Console.WriteLine("7. Enter the name of the AddressBook you want to swtich to");
                Console.WriteLine("8. Enter the name of the AddressBook you want to delete");

                Console.WriteLine("9. Exit");

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
                        Console.WriteLine("Enter the name of Address Book you want to add? ");
                        bookName = Console.ReadLine();

                        addressBook = new AddressBook(bookName, MultiAddressBookObject.get_MultiAddressBookDictionary());
                        break;


                    case "6":
                        
                        foreach(KeyValuePair<string, List<Contact>> addressbook in MultiAddressBookObject.get_MultiAddressBookDictionary())
                        {
                            Console.WriteLine($"{addressbook.Key} : {addressbook.Value.Count}");
                        }
                        Console.ReadLine();
                        break;

                    case "7":
                        

                        foreach (KeyValuePair<string, List<Contact>> addressbook in MultiAddressBookObject.get_MultiAddressBookDictionary())
                        {
                            Console.WriteLine($"{addressbook.Key} : {addressbook.Value.Count}");
                        }

                        Console.WriteLine("Enter the AddressBook name you want to switch to:  ");
                        bookName= Console.ReadLine();
                        break;

                    case "8":
                        Console.WriteLine("Enter the name of Addressbook you want to delete: ");
                        string AddressBookName = Console.ReadLine();
                        if(MultiAddressBookObject.get_MultiAddressBookDictionary().ContainsKey(AddressBookName))
                        {
                            if(AddressBookName != bookName)
                            {
                                MultiAddressBookObject.get_MultiAddressBookDictionary().Remove(AddressBookName);

                            }
                            else
                            {
                                Console.WriteLine("Warning: The present addressbook cannot be deleted. Please switch before deleting.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("The input is not matching the Addressbooks in database");
                        }
                        

                        break;


                    case "9":
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