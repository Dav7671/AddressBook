using System;

namespace AddressBook
{
    class Person
    {
        public Guid _id;
        public string _fullName;
        public string _email;
        public string _physicalAddress;
        public string _phoneNumber;   

        public Person()
        {
            _id = Guid.NewGuid();
        }

        public Person(string fullname, string email, string physicalAddress, string phoneNumber)
        {
            _fullName = fullname;
            _email = email;
            _physicalAddress = physicalAddress;
            _phoneNumber = phoneNumber;
            _id = Guid.NewGuid();
        }
    }
}
