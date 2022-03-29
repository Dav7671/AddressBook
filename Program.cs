using System;


namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookService service = new AddressBookService();
            service.ShowMenu();
            
            Console.Read();
        }
    }
}


