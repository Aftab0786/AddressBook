using Address;
class program
{
    Contact contact = new Contact();
    static void Main(string[] args)
    {
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("Enter the program number to be executed : press 1-CreateContact, 2-Exit");
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
                    flag = false;
                    break;
            }

        }
    }
}
