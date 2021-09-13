using AutoMapper;
using Content.Bll.Core.Models;
using Content.ContentAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactAPI.Mappings
{
    public class ContactViewMappings: Profile
    {
        public ContactViewMappings()
        {
            CreateMap<ContactInput, ContactModel>();
        }
    }
}
