using AddressbookADO.net;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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


    }
}
