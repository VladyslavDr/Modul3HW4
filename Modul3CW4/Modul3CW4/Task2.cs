using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3CW4
{
    public class Task2
    {
        private List<Contact> _contacts = new List<Contact>();

        public List<Contact> GetContacts()
        {
            _contacts.Add(new Contact() { FirstName = "semen", LaststName = "koko" });
            _contacts.Add(new Contact() { FirstName = "samanta", LaststName = "koko" });
            _contacts.Add(new Contact() { FirstName = "oleg", LaststName = "popov" });
            _contacts.Add(new Contact() { FirstName = "sophia", LaststName = "koko" });
            _contacts.Add(new Contact() { FirstName = "valera", LaststName = "popov" });
            _contacts.Add(new Contact() { FirstName = "veronika", LaststName = "ololo" });

            return _contacts;
        }
    }
}
