using AutoMapper;
using Content.Bll.Core.Interfaces;
using Content.Bll.Core.Models;
using Content.ContentAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContentAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly ILogger<ContactController> _logger;
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public ContactController(ILogger<ContactController> logger, IContactService contactService, IMapper mapper)
        {
            _logger = logger;
            _contactService = contactService;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var contact = _contactService.GetContactById(id);
            if (contact == null)
                return NotFound();
            return Ok(contact);
        }

        [HttpGet]
        public IActionResult Get()
        {
            var contacts = _contactService.GetContacts();
            if (contacts == null || contacts.Count() == 0)
                return NoContent();
            return Ok(contacts);
        }

        [HttpPost]
        public IActionResult Post(ContactInput contactInput)
        {
            var contact = _mapper.Map<ContactModel>(contactInput);
            var createdContact = _contactService.CreateContact(contact);
            return Ok(createdContact);
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Patch([FromRoute] int id, [FromBody]ContactInput contactInput)
        {
            var contact = _mapper.Map<ContactModel>(contactInput);
            contact.id = id;
            var updatedContact = _contactService.UpdateContact(contact);
            if (updatedContact == null)
                return NotFound();
            return Ok(updatedContact);
        }
    }
}
