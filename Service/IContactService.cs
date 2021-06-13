using DAL;
using Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IContactService
    {
        List<Contact> GetAllContact();
        int Insert(AddContactRequest contact);
        int Update(UpdateContactRequest contact);
        int Delete(DeleteContactRequest contact);
    }
}
