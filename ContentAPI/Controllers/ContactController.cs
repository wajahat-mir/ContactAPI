using Content.Bll.Core.Interfaces;
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

        public ContactController(ILogger<ContactController> logger, IContactService contactService)
        {
            _logger = logger;
            _contactService = contactService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var contacts = _contactService.GetContacts();
            if (contacts == null || contacts.Count() == 0)
                return NoContent();
            return Ok();
        }
    }
}
