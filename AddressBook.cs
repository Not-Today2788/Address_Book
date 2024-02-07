using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Address_Book
{
    internal class AddressBook
    {
        private List<Contact> contactslist;

        public AddressBook()
        {
            contactslist = new List<Contact>();
        }


        public bool DoesEmailExist(string email)
        {
            return contactslist.Any(contact => string.Equals(contact.Email, email, StringComparison.OrdinalIgnoreCase));
        }

        internal void AddContact()
        {
            /*if (DoesEmailExist(email))
            {
                Console.WriteLine("A contact with the same email already exists. Contact not added.");
                return;
            }*/

            // User input details and send the details through constructor


            Contact newContact = new Contact();


            Console.WriteLine("Write email");
            string email = Console.ReadLine();
            if (DoesEmailExist(email))
            {
                Console.WriteLine("Email already exist! Enter again...");
                Console.WriteLine("Press Enter to Exit");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("write Phone Number ");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Write Pincode ");
            string zip = Console.ReadLine();
            Console.WriteLine("Write address");
            string address = Console.ReadLine();
            Console.WriteLine("Write City ");
            string city = Console.ReadLine();
            Console.WriteLine("Write Country ");
            string country = Console.ReadLine();
            Console.WriteLine("Write State");
            string state = Console.ReadLine();

            newContact.FirstName = firstName;
            newContact.LastName = lastName;
            newContact.Address = address;
            newContact.City = city;
            newContact.State = state;
            newContact.Country = country;
            newContact.Zip = zip;
            newContact.PhoneNumber = phoneNumber;
            newContact.Email = email;

            contactslist.Add(newContact);
            Console.WriteLine("Contact added successfully!");
        }
    }
}
