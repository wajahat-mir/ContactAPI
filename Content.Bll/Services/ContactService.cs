using Content.Bll.Core.Interfaces;
using Content.Bll.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Content.Bll.Services
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepository;

        public ContactService(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public IEnumerable<ContactModel> GetContacts()
        {
            return _contactRepository.GetContacts();
        }

        public ContactModel CreateContact(ContactModel contact)
        {
            return _contactRepository.CreateContact(contact);
        }

        public ContactModel GetContactById(int id)
        {
            return _contactRepository.GetContactById(id);
        }

        public ContactModel UpdateContact(ContactModel contact)
        {
            var existsContact = _contactRepository.GetContactById(contact.id);
            if(existsContact != null)
                return _contactRepository.UpdateContact(contact);
            return null;
        }
    }
}
