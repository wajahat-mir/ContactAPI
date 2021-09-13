using Content.Bll.Core.Interfaces;
using Content.Bll.Core.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Tests.RepositoryMocks
{
    public class ContactRepositoryMock
    {
        public static Mock<IContactRepository> GetContacts_ReturnsNull()
        {
            var mock = new Mock<IContactRepository>();
            IEnumerable<ContactModel> contacts = null;
            mock.Setup(x => x.GetContacts()).Returns(contacts);
            return mock;
        }

        public static Mock<IContactRepository> GetContactById_ReturnsNull()
        {
            var mock = new Mock<IContactRepository>();
            ContactModel contact = null;
            mock.Setup(x => x.GetContactById(It.IsAny<int>())).Returns(contact);
            return mock;
        }

        public static Mock<IContactRepository> GetContactById_UpdatesSuccessfully_ReturnsContact()
        {
            var mock = new Mock<IContactRepository>();
            ContactModel contact = new ContactModel()
            {
                id = 1,
                name = "test",
                address = "home",
            };

            ContactModel contact2 = new ContactModel()
            {
                id = 1,
                name = "test2",
                address = "home",
            };
            mock.Setup(x => x.UpdateContact(It.IsAny<ContactModel>())).Returns(contact2);
            mock.Setup(x => x.GetContactById(It.IsAny<int>())).Returns(contact);
            return mock;
        }

        public static Mock<IContactRepository> GetContactById_UpdatesFailes_ReturnsNull()
        {
            var mock = new Mock<IContactRepository>();
            ContactModel contact = new ContactModel()
            {
                id = 1,
                name = "test",
                address = "home",
            };

            ContactModel contact2 = null;
            mock.Setup(x => x.UpdateContact(It.IsAny<ContactModel>())).Returns(contact2);
            mock.Setup(x => x.GetContactById(It.IsAny<int>())).Returns(contact);
            return mock;
        }

        public static Mock<IContactRepository> GetContactById_ReturnsContact()
        {
            var mock = new Mock<IContactRepository>();
            ContactModel contact = new ContactModel()
            {
                id = 1,
                name = "test",
                address = "home",
            };
            mock.Setup(x => x.GetContactById(It.IsAny<int>())).Returns(contact);
            return mock;
        }

        public static Mock<IContactRepository> CreateContact_ReturnsContact()
        {
            var mock = new Mock<IContactRepository>();
            ContactModel contact = new ContactModel()
            {
                id = 1,
                name = "test",
                address = "home",
            };
            mock.Setup(x => x.CreateContact(It.IsAny<ContactModel>())).Returns(contact);
            return mock;
        }

        public static Mock<IContactRepository> GetContacts_ReturnsListOfContacts()
        {
            var mock = new Mock<IContactRepository>();
            List<ContactModel> contacts = new List<ContactModel>()
            {
                new ContactModel()
                {
                    id = 1,
                    name = "test",
                    address = "home"
                }
            };
            mock.Setup(x => x.GetContacts()).Returns(contacts);
            return mock;
        }
    }
}
