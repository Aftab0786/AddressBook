using Address;
class program
{
    Contact contact = new Contact();
    static void Main(string[] args)
    {
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("Enter the program number to be executed : press 1-CreateContact, 2-AddContact, 3-EditContact, 4-Exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the Contact Information in Format of FirstName, LastName, Addr, City, State, Zip, Ph.No, Email.");
                    Contact contact = new Contact();
                    Contact newContact = new Contact();
                    newContact.FirstName = Console.ReadLine();
                    newContact.LastName = Console.ReadLine();
                    newContact.Address = Console.ReadLine();
                    newContact.City = Console.ReadLine();
                    newContact.State = Console.ReadLine();
                    newContact.PostalCode = Console.ReadLine();
                    newContact.PhoneNumber = Console.ReadLine();
                    newContact.Email = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Enter the Contact Information to be Add in form of FirstName, LastName, Addr, City, State, Zip, Ph.No, Email.");
                    Console.WriteLine("Enter the Contact to be Add: ");
                    Contact contact1 = new Contact();
                    AddressBook addressBook = new AddressBook();
                    addressBook.AddContact(contact1);
                    contact1.FirstName = Console.ReadLine();
                    contact1.LastName = Console.ReadLine();
                    contact1.Address = Console.ReadLine();
                    contact1.City = Console.ReadLine();
                    contact1.State = Console.ReadLine();
                    contact1.PostalCode = Console.ReadLine();
                    contact1.PhoneNumber = Console.ReadLine();
                    contact1.Email = Console.ReadLine();
                    addressBook.Display();
                    break;
                case 3:
                    Console.WriteLine("Enter the Contact Name to be Edited: ");
                    string name = Console.ReadLine();
                    AddressBook ab = new AddressBook();
                    ab.EditContact(name);
                    ab.Display();
                    break;
                case 4:
                    flag = false;
                    break;
            }

        }
    }
}
