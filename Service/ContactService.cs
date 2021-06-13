using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Request;

namespace Service
{
    public class ContactService : IContactService
    {
        private IContactRepository _contactRepo;

        public ContactService(IContactRepository contactRepo)
        {
            _contactRepo = contactRepo;
        }

        public List<Contact> GetAllContact()
        {
            return _contactRepo.GetContact();
        }
        public int Insert(AddContactRequest contact)
        {
            return _contactRepo.Insert(contact);
        }
        public int Update(UpdateContactRequest contact)
        {
            return _contactRepo.Update(contact);
        }
        public int Delete(DeleteContactRequest contact)
        {
            return _contactRepo.Delete(contact);
        }
    }
}
