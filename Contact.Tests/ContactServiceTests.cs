using Contact.Tests.RepositoryMocks;
using Content.Bll.Core.Models;
using Content.Bll.Services;
using Moq;
using System;
using Xunit;

namespace Contact.Tests
{
    public class ContactServiceTests
    {
        [Fact]
        public void GetContacts_ShouldReturnNothing_WhenEmpty()
        {
            var contactRepo = ContactRepositoryMock.GetContacts_ReturnsNull();
            var contactService = new ContactService(contactRepo.Object);
            
            var result = contactService.GetContacts();

            Assert.Null(result);
        }

        [Fact]
        public void UpdateContacts_ShouldReturnNothing_WhenRecordDoesntExist()
        {
            var contactRepo = ContactRepositoryMock.GetContactById_ReturnsNull();
            var contactService = new ContactService(contactRepo.Object);

            var contact = new ContactModel()
            {
                id = 1,
                name = "test",
                address = "home",
            };
            var result = contactService.UpdateContact(contact);

            Assert.Null(result);
        }

        [Fact]
        public void UpdateContacts_ShouldReturnContact_WhenRecordExists()
        {
            var contactRepo = ContactRepositoryMock.GetContactById_UpdatesSuccessfully_ReturnsContact();
            var contactService = new ContactService(contactRepo.Object);

            var contact = new ContactModel()
            {
                id = 1,
                name = "test2",
                address = "home",
            };
            var result = contactService.UpdateContact(contact);

            Assert.NotNull(result);
            Assert.Equal("test2", result.name);
        }

        [Fact]
        public void UpdateContacts_ShouldReturnNull_WhenUpdateFails()
        {
            var contactRepo = ContactRepositoryMock.GetContactById_UpdatesFailes_ReturnsNull();
            var contactService = new ContactService(contactRepo.Object);

            var contact = new ContactModel()
            {
                id = 1,
                name = "test2",
                address = "home",
            };
            var result = contactService.UpdateContact(contact);

            Assert.Null(result);
        }

        [Fact]
        public void GetById_ShouldReturnNull_WhenDoesnotExist()
        {
            var contactRepo = ContactRepositoryMock.GetContactById_ReturnsNull();
            var contactService = new ContactService(contactRepo.Object);

            var result = contactService.GetContactById(It.IsAny<int>());

            Assert.Null(result);
        }

        [Fact]
        public void GetById_ShouldReturnContact_WhenExists()
        {
            var contactRepo = ContactRepositoryMock.GetContactById_ReturnsContact();
            var contactService = new ContactService(contactRepo.Object);

            var result = contactService.GetContactById(It.IsAny<int>());

            Assert.NotNull(result);
        }

        [Fact]
        public void CreateContact_ShouldReturnContact_WhenSucceeds()
        {
            var contactRepo = ContactRepositoryMock.CreateContact_ReturnsContact();
            var contactService = new ContactService(contactRepo.Object);

            var result = contactService.CreateContact(It.IsAny<ContactModel>());

            Assert.NotNull(result);
        }

        [Fact]
        public void GetContacts_ShouldReturnContacts_WhenSucceeds()
        {
            var contactRepo = ContactRepositoryMock.GetContacts_ReturnsListOfContacts();
            var contactService = new ContactService(contactRepo.Object);

            var result = contactService.GetContacts();

            Assert.NotNull(result);
        }
    }
}
