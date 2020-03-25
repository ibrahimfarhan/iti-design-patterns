using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    class Person
    {
        public string Name { get; set; }
        public string Company { get; set; }
        public string JobTitle { get; set; }
        public int Salary { get; set; }
        public string Country { get; set; }
        public string City { get; set; }

        public Person()
        {

        }

        // To avoid using a constructor with many parameters like this, use the builder pattern.
        public Person(string name, string company, string jobTitle, int salary, string country, string city)
        {
            Name = name;
            Company = company;
            JobTitle = jobTitle;
            Salary = salary;
            Country = country;
            City = city;
        }

        public override string ToString()
        {
            return $"{Name} lives in {City}, {Country}, works for {Company}, and earns ${Salary}";
        }
    }
}
