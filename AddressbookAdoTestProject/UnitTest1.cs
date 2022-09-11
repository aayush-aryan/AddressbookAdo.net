using AddressbookADO.net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AddressbookAdoTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_ForCheckingNumberOfRecordsInDatabeses()
        {
            AddressBookRepository addressBookRepository = new AddressBookRepository();
            int actualNumberOfRow=addressBookRepository.GetAllContact();
            int expectedNumberOfRow = 3;
            Assert.AreEqual(expectedNumberOfRow, actualNumberOfRow);
        }

        [TestMethod]
        public void TestMethod_ForUpdatigRecordsInDatabeses()
        {
            AddressBookRepository addressBookRepository = new AddressBookRepository();
            int actualResult = addressBookRepository.UpdateAddreessBookRecordsByContactId(1);
            int expectedResult = 1;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod_ForRetrivingRecordsForPartiularTimePeriod()
        {
            AddressBookRepository addressBookRepository = new AddressBookRepository();
            int actualRow = addressBookRepository.GetContactDetailsAddedInParticularPeriod("2018-01-01", "2022-01-01");
            int expectedRow = 2;
            Assert.AreEqual(expectedRow, actualRow);
        }

        [TestMethod]
        public void TestMethod_ForRetrivingRecordsByCityOrState()
        {
            AddressBookRepository addressBookRepository = new AddressBookRepository();
            int actualRow = addressBookRepository.RetrieveContactFromCityOrStateName("Grugram", "Haryana");
            int expectedRow = 1;
            Assert.AreEqual(expectedRow, actualRow);
        }
        [TestMethod]
        public void TestMethod_ForaddigcontactsInDB()
        {
            AddressBookRepository addressBookRepository = new AddressBookRepository();

            AddressBookModel model = new AddressBookModel();
            model.FirstName = "Amit";
            model.LastName = "Sharma";
            model.Address = "sector-70";
            model.City = "Noida";
            model.State = "UttarPardesh";
            model.ZipCode = "800900";
            model.PhoneNumber = "8311155510";
            model.EmailId = "amit@gmail.com";
            model.AddressBookType = "Friend";
            model.AddressBookName = "expecte";
            model.AddedDate = Convert.ToDateTime("2022-02-02");
           bool actual = addressBookRepository.AddContactsInAddressBook(model);
            bool expecte = true;
            Assert.AreEqual(expecte, actual);
        }

    }
}
