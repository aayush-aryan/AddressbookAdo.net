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
    }
}