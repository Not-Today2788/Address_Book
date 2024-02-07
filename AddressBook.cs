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

        private string GetContactInfo(Contact contact)
        {
            return $"Name: {contact.FirstName} {contact.LastName}\n" +
                   $"Address: {contact.Address}, {contact.City}, {contact.State}, {contact.Country} - {contact.Zip}\n" +
                   $"Phone Number: {contact.PhoneNumber}\n" +
                   $"Email: {contact.Email}\n";
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

        


        internal void EditContact(string email) // for loop to iterate through the list and edit the particular email through if statement
        {
            Console.WriteLine("Enter what you want to update");
            Console.WriteLine("1. Email");
            Console.WriteLine("2. firstName");
            Console.WriteLine("3. lastName");
            Console.WriteLine("4. Address");
            Console.WriteLine("5. City");
            Console.WriteLine("6. State");
            Console.WriteLine("7. Country");
            Console.WriteLine("8. Zip Code");
            Console.WriteLine("9. phoneNumber");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the New Email: ");
                    string newemail = Console.ReadLine();
                    if (DoesEmailExist(newemail))
                    {
                        Contact obj = contactslist.Find(contact => contact.Email == email);
                        obj.Email = newemail;
                    }
                    else
                    {
                        Console.WriteLine("This email already exists!!!");
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter the New firstName: ");
                    string newfirstName = Console.ReadLine();
                    if (DoesEmailExist(email))
                    {
                        Contact obj = contactslist.Find(contact => contact.Email == email);
                        obj.FirstName = newfirstName;
                    }

                    break;
                case 3:
                    Console.WriteLine("Enter the New lastName: ");
                    string newlastName = Console.ReadLine();
                    if (DoesEmailExist(email))
                    {
                        Contact obj = contactslist.Find(contact => contact.Email == email);
                        obj.LastName = newlastName;
                    }
                    break;
                case 4:
                    Console.WriteLine("Enter the new Address: ");
                    string newAddress = Console.ReadLine();
                    if (DoesEmailExist(email))
                    {
                        Contact obj = contactslist.Find(contact => contact.Email == email);
                        obj.Address = newAddress;
                    }
                    break;
                case 5:
                    Console.WriteLine("Enter the new City: ");
                    string newCity = Console.ReadLine();
                    if (DoesEmailExist(email))
                    {
                        Contact obj = contactslist.Find(contact => contact.Email == email);
                        obj.City = newCity;
                    }
                    break;
                case 6:
                    Console.WriteLine("Enter new State: ");
                    string newState = Console.ReadLine();
                    if (DoesEmailExist(email))
                    {
                        Contact obj = contactslist.Find(contact => contact.Email == email);
                        obj.State = newState;
                    }
                    break;

                case 7:
                    Console.WriteLine("Enter new Country: ");
                    string newCountry = Console.ReadLine();
                    if (DoesEmailExist(email))
                    {
                        Contact obj = contactslist.Find(Contact => Contact.Email == email);
                        obj.Country = newCountry;
                    }
                    break;

                case 8:
                    Console.WriteLine("Enter new Pincode: ");
                    string newPincode = Console.ReadLine();
                    if (DoesEmailExist(email))
                    {
                        Contact obj = contactslist.Find(contact => contact.Email == email);
                        obj.Zip = newPincode;
                    }
                    break;

                case 9:
                    Console.WriteLine("Enter new phonenumber: ");
                    string newPhonenumber = Console.ReadLine();
                    if (DoesEmailExist(email))
                    {
                        Contact obj = contactslist.Find(contact => contact.Email == email);
                        obj.PhoneNumber = newPhonenumber;
                    }
                    break;
            }

            
        }

        internal void DisplayContacts()
        {
            for (int i = 0; i < contactslist.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {GetContactInfo(contactslist[i])}\n");
            }
        }

        internal void DeleteContact(string email)
        {
            if (DoesEmailExist(email))
            {
                Contact obj = contactslist.Find(contact => contact.Email == email);
                contactslist.Remove(obj);
            }
        }
    }
}
