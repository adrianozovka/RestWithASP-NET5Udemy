using RestWithASP_NET5Udemy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RestWithASP_NET5Udemy.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
           
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for(int i= 0; i<8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }

            return persons;
        }

        public Person FindByID(long id)
        {
            return new Person
            {
                Id = IncrementANdGet(),
                FirstName = "Adriano",
                LastName = "Melo",
                Address = "Recife, Pernambuco, Brazil",
                Gender = "Male"
            };
        }


        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementANdGet(),
                FirstName = "First Name" + i,
                LastName = "Last Name" + i,
                Address = "Some Address" + i,
                Gender = "Male"
            };
        }

        private long IncrementANdGet()
        {
            return Interlocked.Increment(ref count);
        }

        public Person Update(Person person)
        {
            return person;
        }
    }
}
