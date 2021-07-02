using RestWithASP_NET5Udemy.Data.Converter.Implementations;
using RestWithASP_NET5Udemy.Data.VO;
using RestWithASP_NET5Udemy.Model;
using RestWithASP_NET5Udemy.Model.Context;
using RestWithASP_NET5Udemy.Repository;
using System.Collections.Generic;
using System.Linq;

namespace RestWithASP_NET5Udemy.Business.Implementations
{
    public class PersonBusinessmplementation : IPersonBusiness
    {
        private readonly IRepository<Person> _repository;

        private readonly PersonConverter _converter;

        public PersonBusinessmplementation(IRepository<Person> repository)
        {
            _repository = repository;
            _converter = new PersonConverter();

        }


        public List<PersonVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }


        public PersonVO FindByID(long id)
        {
            return _converter.Parse(_repository.FindByID(id));
        }



        public PersonVO Create(PersonVO person)
        {
            return _converter.Parse(_repository.Create(_converter.Parse(person)));
        }

        public PersonVO Update(PersonVO person)
        {
            return _converter.Parse(_repository.Update(_converter.Parse(person)));
        }


        public void Delete(long id)
        {
            _repository.Delete(id);

        }
    }
}
