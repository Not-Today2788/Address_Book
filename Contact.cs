using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    internal class Contact
    {
        private string firstName;
        private string lastName;
        private string address;
        private string city;
        private string state;
        private string country;
        private string zip;
        private string phoneNumber;
        private string email;


        public Contact(string firstname, string lastname, string address, string city, string state, string country, string zip, string phoneNumber, string email)
        {
            this.firstName = firstname;
            this.lastName = lastname;
            this.address = address;
            this.city = city;
            this.state = state;
            this.country = country;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

        public Contact()
        {
            this.firstName = "";
            this.lastName = "";
            this.address = "";
            this.city = "";
            this.state = "";
            this.country = "";
            this.zip = "";
            this.phoneNumber = "";
            this.email = "";
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public string Country
        {
            get { return country; }
            set { state = value; }
        }
        public string Zip
        {
            get { return zip; }
            set { zip = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

    }
}
