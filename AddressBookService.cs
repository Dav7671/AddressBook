using System;

namespace AddressBook
{
    public class AddressBookService
    {
        AddressBookManager addressBook = new AddressBookManager();
        private void Create()
        {
            Person person = new Person();
            string fullname, email, phoneNumber;
            do
            {
                Console.WriteLine("Please enter contact full name");
                fullname = Console.ReadLine();
            }
            while (!ValidationHelper.IsValidName(fullname));
            person._fullName = fullname;

            do
            {
                Console.WriteLine("Please enter contact email address");
                email = Console.ReadLine();
            }
            while (!ValidationHelper.IsValidEmail(email));
            person._email = email;

            do
            {
                Console.WriteLine("Please enter contact phone number");
                phoneNumber = Console.ReadLine();
            }
            while (!ValidationHelper.IsValidPhone(phoneNumber));
            person._phoneNumber = phoneNumber;

            Console.WriteLine("Please enter contact physical address");
            person._physicalAddress = Console.ReadLine();
            Console.WriteLine("Contact has been created");
            addressBook.Add(person);
        }

        private void FindByName()
        {
            Console.WriteLine("Please type name to search");
            var name = Console.ReadLine();
            var person = addressBook.GetByName(name);
            if (person == null) Console.WriteLine("Contact not found!");
            else { PrintPerson(person); }
        }

        private void FindById()
        {
            Console.WriteLine("Please type contact's ID to search");
            var id = Console.ReadLine();
            var person = addressBook.GetById(id);
            if (person == null) Console.WriteLine("Contact not found!");
            else { PrintPerson(person); }
        }

        private void ShowAll()
        {
            var list = addressBook.GetAll();
            foreach (Person person in list)
            {
                PrintPerson(person);
            }
        }

        private void Delete()
        {
            Console.WriteLine("Please type contact's ID to delete");
            var id = Console.ReadLine();
            var person = addressBook.GetById(id);
            if (person == null) Console.WriteLine("Contact not found!");
            else
            {
                var success = addressBook.Delete(person);
                if (success) Console.WriteLine("Contact has been deleted");
            }
        }

        private void Edit()
        {
            Console.WriteLine("Please type contact's ID to edit");
            string fullname, email, phoneNumber, address;
            var id = Console.ReadLine();
            var person = addressBook.GetById(id);
            if (person == null)
            {
                Console.WriteLine("Contact not found!");
                return;
            }

            Console.WriteLine("\nPlease write what you need to change \n" +
                              "For full name write (1) \n" +
                              "For email write (2) \n" +
                              "For address write (3)\n" +
                              "For phone number write (4)");
            var edit = Console.ReadLine();
            switch (edit)
            {
                case "1":
                    do
                    {
                        Console.WriteLine("Please enter contact full name");
                        fullname = Console.ReadLine();
                    }
                    while (!ValidationHelper.IsValidName(fullname));
                    addressBook.UpdateName(id, fullname);
                    break;
                case "2":
                    do
                    {
                        Console.WriteLine("Please enter contact email address");
                        email = Console.ReadLine();
                    }
                    while (!ValidationHelper.IsValidEmail(email));
                    addressBook.UpdateEmail(id, email);
                    break;
                case "3":
                    Console.WriteLine("Please enter contact physical address");
                    address = Console.ReadLine();
                    addressBook.UpdateAddress(id, address);
                    break;
                case "4":
                    do
                    {
                        Console.WriteLine("Please enter contact phone number");
                        phoneNumber = Console.ReadLine();
                    }
                    while (!ValidationHelper.IsValidPhone(phoneNumber));
                    addressBook.UpdatePhone(id, phoneNumber);
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

        }

        public void ShowMenu()
        {
            Console.WriteLine("\nEnter the operation which you want to do: \n" +
                              "Create new contact(1), \n" +
                              "Find a single contact by name (2), \n" +
                              "Find a single contact by ID (3), \n" +
                              "View all contacts(4), \n" +
                              "Edit a contact(5) \n" +
                              "Delete a contact(6) \n");
            var enter = Console.ReadLine();
            switch (enter)
            {
                case "1":
                    Create();
                    break;
                case "2":
                    FindByName();
                    break;
                case "3":
                    FindById();
                    break;
                case "4":
                    ShowAll();
                    break;
                case "5":
                    Edit();
                    break;
                case "6":
                    Delete();
                    break;
                default:
                    Console.WriteLine("Ivalid enter");
                    break;
            }
            ShowMenu();
        }

        private void PrintPerson(Person person)
        {
            Console.WriteLine("Full Name:              {person._fullName} \n" +
                              "Phone Number:           {person._phoneNumber} \n" +
                              "Address:                {person._physicalAddress} \n" +
                              "Email:                  {person._email} \n" +
                              "ID:                     {person._id} \n" +
                              "-------------------------------------------");
        }
    }
}
