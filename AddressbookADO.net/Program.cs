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
            //int rowcount=addressBookRepository.GetAllContact();
            //addressBookRepository.UpdateAddreessBookRecordsByContactId(1);
          // int Rcount= addressBookRepository.GetContactDetailsAddedInParticularPeriod("2018-01-01","2022-01-01");
           // Console.WriteLine(Rcount);
            int RCount=addressBookRepository.RetrieveContactFromCityOrStateName("Grugram","Haryana");
            Console.WriteLine("No of records :"+RCount);
        }
    }
}
