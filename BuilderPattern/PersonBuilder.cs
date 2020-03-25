using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    class PersonBuilder
    {
        protected Person person = new Person();
        public PersonJobBuilder Works => new PersonJobBuilder(person);
        public PersonAddressBuilder Lives => new PersonAddressBuilder(person);

        public static implicit operator Person(PersonBuilder pb)
        {
            return pb.person;
        }

        public PersonBuilder IsCalled(string name)
        {
            person.Name = name;
            return this;
        }
    }
}
