using System;

namespace AddressbookADO.net
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook ADO.net");

            AddressBookRepository addressBookRepository = new AddressBookRepository();
            //addressBookRepository.DataBaseConnection();
            int rowcount=addressBookRepository.GetAllContact();
        }
    }
}
