using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactConsoleApp
{
    class PhoneBook
    {
        private List<Contact> _contacts { get; set; } = new List<Contact>();
        private void DisplayContactDetails(Contact contact)
        {
            Console.WriteLine($"Contact: {contact.Name}, {contact.Number}");
        }

        private void DisplayContactDetails(List<Contact> contacts)
        {
            foreach (var contact in _contacts)
            {
                DisplayContactDetails(contact);
            }
        }

        public void AddContact(Contact contact)
        {
            _contacts.Add(contact);
        }

        public void DisplayContact(string number)
        {
            var contact = _contacts.FirstOrDefault(c => c.Number == number);
            if (contact == null)
            {
                Console.WriteLine("Contact not found");
            }
            else
            {
                DisplayContactDetails(contact);
            }
        }

        public void DisplayAllContact()
        {
            DisplayContactDetails(_contacts);
            
        }

        public void DisplayMatchingContact(string searchPhrase)
        {
            //name: Ryan
            //can search by any letter in name?GOOD?BAD?
            var matchingContacts = _contacts.Where(c => c.Name.Contains(searchPhrase)).ToList();
            DisplayContactDetails(matchingContacts);

        }
    }
}
