using Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IContactRepository
    {
        List<Contact> GetContact();
        int Insert(AddContactRequest contact);
        int Delete(DeleteContactRequest contact);
        int Update(UpdateContactRequest contact);

    }
}
