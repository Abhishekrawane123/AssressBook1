using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Address Book ");
            AddressBook1 addressBook = new AddressBook1();
            addressBook.acceptData();
        }
    }
}
