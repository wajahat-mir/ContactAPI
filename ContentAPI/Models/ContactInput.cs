using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Content.ContentAPI.Models
{
    public class ContactInput
    {
        public string name { get; set; }
        public string title { get; set; }
        public string company { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public DateTime lastDateContacted { get; set; }
        public string comments { get; set; }
    }
}
