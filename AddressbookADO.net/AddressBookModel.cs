using System;
using System.Collections.Generic;
using System.Text;

namespace AddressbookADO.net
{
    public class AddressBookModel
    {
        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailId { get; set; }
        public string AddressBookType { get; set; }
        public string AddressBookName { get; set; }
        public DateTime AddedDate { get; set; }
    }
}
