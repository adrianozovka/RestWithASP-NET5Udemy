using RestWithASP_NET5Udemy.Data.VO;
using RestWithASP_NET5Udemy.Model;
using System.Collections.Generic;

namespace RestWithASP_NET5Udemy.Business
{
    public interface IPersonBusiness
    {

        PersonVO Create(PersonVO person);

        PersonVO Update(PersonVO person);

        List<PersonVO> FindAll();

        PersonVO FindByID(long id);

        void Delete(long id);

    }
}
