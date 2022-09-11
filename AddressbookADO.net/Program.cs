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
           // int RCount=addressBookRepository.RetrieveContactFromCityOrStateName("Grugram","Haryana");
           // Console.WriteLine("No of records :"+RCount);

            AddressBookModel model = new AddressBookModel();
            model.FirstName = "Ram";
            model.LastName = "Singh";
            model.Address = "sector-75";
            model.City = "Noida";
            model.State = "UttarPardesh";
            model.ZipCode = "800300";
            model.PhoneNumber = "8311111110";
            model.EmailId = "ram@gmail.com";
            model.AddressBookType = "Friend";
            model.AddressBookName = "Ram";
            model.AddedDate = Convert.ToDateTime("2022-01-02");
            addressBookRepository.AddContactsInAddressBook(model);
          //addressBookRepository.GetAllContact();
        }
    }
}
