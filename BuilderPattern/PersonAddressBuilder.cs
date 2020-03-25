using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    class PersonAddressBuilder : PersonBuilder
    {
        public PersonAddressBuilder(Person person)
        {
            this.person = person;
        }

        public PersonAddressBuilder InCountry(string country)
        {
            person.Country = country;
            return this;
        }

        public PersonAddressBuilder InCity(string city)
        {
            person.City = city;
            return this;
        }
    }
}
