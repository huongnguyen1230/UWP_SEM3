using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Models
{
    class Contact
    {
        public string ContactName { get; set; }

        public string ContactAddress { get; set; }

        public Contact(string contactName, string contactAddress)
        {
            ContactName = contactName;
            ContactAddress = contactAddress;
        }
    }
}
