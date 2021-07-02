using RestWithASP_NET5Udemy.Model;
using System.Collections.Generic;

namespace RestWithASP_NET5Udemy.Business
{
    public interface IPersonBusiness
    {

        Person Create(Person person);

        Person Update(Person person);

        List<Person> FindAll();

        Person FindByID(long id);

        void Delete(long id);

    }
}
