using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class PersonJob
    {
        private int id { get; }
        private Movie movie { get; set; }
        private Person person { get; set; }
        private PersonType personType { get; set; }
        public PersonJob(Person p, PersonType pt)
        {
            person = p;
            personType = pt;
        }
        public string toString()
        {
            return this.person.toString() + " " + this.personType.toString();
        }
    }
}
