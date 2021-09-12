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
        private Dictionary<int, ContactModel> contacts = new Dictionary<int, ContactModel>();

        public IEnumerable<ContactModel> GetContacts()
        {
            return contacts.Values;
        }
    }
}
