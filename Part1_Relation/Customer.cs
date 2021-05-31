using System;

namespace Part1_Relation
{
    public class Customer
    {
        public Customer()
        {
            CustomerId = Guid.NewGuid();
        }
        public Guid CustomerId { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }

        public int Age { get; set; }

    }
}
