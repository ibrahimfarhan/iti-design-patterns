using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    class PersonJobBuilder : PersonBuilder
    {
        public PersonJobBuilder(Person person)
        {
            this.person = person;
        }

        public PersonJobBuilder As(string jobTitle)
        {
            person.JobTitle = jobTitle;
            return this;
        }

        public PersonJobBuilder InCompany(string company)
        {
            person.Company = company;
            return this;
        }

        public PersonJobBuilder Earns(int salary)
        {
            person.Salary = salary;
            return this;
        }
    }
}
