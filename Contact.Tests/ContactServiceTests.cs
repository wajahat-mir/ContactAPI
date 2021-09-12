using Contact.Tests.RepositoryMocks;
using Content.Bll.Services;
using System;
using Xunit;

namespace Contact.Tests
{
    public class ContactServiceTests
    {
        [Fact]
        public void GetContacts_ShouldReturnNothing_WhenEmpty()
        {
            var contactRepo = ContactRepositoryMock.GetRules_ReturnsNullDataSet();
            var contactService = new ContactService(contactRepo.Object);
            
            var result = contactService.GetContacts();

            Assert.Null(result);
        }
    }
}
