using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new PersonBuilder().
                IsCalled("Ahmed").
                Lives.InCountry("Egypt").
                InCity("Cairo").
                Works.As("Engineer").
                InCompany("Microsoft").
                Earns(3000);

            Console.WriteLine(p.ToString());
        }
    }
}
