using RestWithASP_NET5Udemy.Model;
using System.Collections.Generic;

namespace RestWithASP_NET5Udemy.Repository
{
    public interface IPersonRepository
    {

        Person Create(Person person);

        Person Update(Person person);

        List<Person> FindAll();

        Person FindByID(long id);

        void Delete(long id);

        bool Exists(long id);

    }
}
