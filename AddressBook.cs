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
    }
}
