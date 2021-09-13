using Content.Bll.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Content.Bll.Core.Interfaces
{
    public interface IContactRepository
    {
        IEnumerable<ContactModel> GetContacts();
        ContactModel CreateContact(ContactModel contact);
        ContactModel GetContactById(int id);
        ContactModel UpdateContact(ContactModel contact);
    }
}
