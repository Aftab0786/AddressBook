using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address
{
    public class AddressBook
    {

        List<Contact> addressList = new List<Contact>();
        public void AddContact(Contact contact)
        {
            addressList.Add(contact);
        }
        public void Display()
        {
            foreach (Contact contact in addressList)
            {
                Console.WriteLine(contact.FirstName + " " + contact.LastName);
                Console.WriteLine("First Name: " + contact.FirstName);
                Console.WriteLine("Last Name: " + contact.LastName);
                Console.WriteLine("Address : " + contact.Address);
                Console.WriteLine("City : " + contact.City);
                Console.WriteLine("State : " + contact.State);
                Console.WriteLine("Postal Code : " + contact.PostalCode);
                Console.WriteLine("Phone Number : " + contact.PhoneNumber);
                Console.WriteLine("Email : " + contact.Email);

            }
        }
        public void EditContact(string name)
        {
            foreach (var contact in addressList)
            {
                if (contact.FirstName == name || contact.LastName == name)
                {
                    Console.WriteLine("What is Required to be Edited");
                }
            }
        }
    }
}
