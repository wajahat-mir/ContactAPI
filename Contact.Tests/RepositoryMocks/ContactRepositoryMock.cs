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
    }
}
