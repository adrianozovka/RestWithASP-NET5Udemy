using RestWithASP_NET5Udemy.Model;
using System.Collections.Generic;

namespace RestWithASP_NET5Udemy.Services
{
    public interface IPersonService
    {

        Person Create(Person person);

        Person Update(Person person);

        List<Person> FindAll();

        Person FindByID(long id);

        void Delete(long id);

    }
}
