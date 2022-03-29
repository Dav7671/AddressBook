using System.Collections.Generic;

namespace AddressBook
{
    class AddressBookManager
    {
        private List<Person> addressBook = new List<Person>();
        public AddressBookManager()
        {
            addressBook.Add(new Person("Davit Margaryan", "davitmargaryan@mail.com", "Erevan", "123123"));
            addressBook.Add(new Person("Arman Grigoryan", "armangrigoryan@mail.com", "Gyumri", "458792"));
            addressBook.Add(new Person("Ashot Sargsyan", "ashotsargsyan95@mail.com", "Erevan", "188893"));
            addressBook.Add(new Person("Armine Sahakyan", "arminesahakyan@mail.com", "Sevan", "198343"));
            addressBook.Add(new Person("Garegin Navasardyan", "garnav@mail.com", "Erevan", "789654"));
            addressBook.Add(new Person("Anahit Galstyan", "angalstyan@mail.com", "Vanadzor", "456369"));
            addressBook.Add(new Person("Lilit Babayan", "lilitbabayan@mail.com", "Erevan", "741852"));
        }
        public void Add(Person person)
        {
            addressBook.Add(person);
        }

        public List<Person> GetAll()
        {
            return addressBook;
        }

        public Person GetByName(string name)
        {
            return addressBook.Find(p => p._fullName.ToLowerInvariant().Contains(name.ToLowerInvariant()));
        }

        public Person GetById(string id)
        {
            return addressBook.Find(p => p._id.ToString() == id);
        }

        public bool Delete(Person person)
        {
            return addressBook.Remove(person);
        }

        public void UpdateName(string id,string fullname)
        {
            addressBook.Find(p => p._id.ToString() == id)._fullName = fullname;

        }
        
        public void UpdateEmail(string id, string email)
        {
            addressBook.Find(p => p._id.ToString() == id)._email = email;
        }

        public void UpdateAddress(string id, string address)
        {
            addressBook.Find(p => p._id.ToString() == id)._physicalAddress = address;
        }

        public void UpdatePhone(string id, string phoneNumber)
        {
            addressBook.Find(p => p._id.ToString() == id)._phoneNumber = phoneNumber;
        }
    }
}

