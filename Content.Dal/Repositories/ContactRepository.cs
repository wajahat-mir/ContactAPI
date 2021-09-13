using Content.Bll.Core.Interfaces;
using Content.Bll.Core.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Content.Dal.Repositories
{
    public class ContactRepository: IContactRepository
    {
        private Dictionary<int, ContactModel> contacts;

        public ContactRepository()
        {
            contacts = new Dictionary<int, ContactModel>();
        }

        public IEnumerable<ContactModel> GetContacts()
        {
            return contacts.Values;
        }

        public ContactModel CreateContact(ContactModel contact)
        {
            var maxId = contacts.Count() > 0 ? contacts.Keys.Max(): 0;
            contact.id = maxId + 1;
            contacts.Add(maxId + 1, contact);
            return contact;
        }
    }
}
