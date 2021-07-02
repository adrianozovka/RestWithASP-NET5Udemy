using RestWithASP_NET5Udemy.Data.Converter.Implementations;
using RestWithASP_NET5Udemy.Data.VO;
using RestWithASP_NET5Udemy.Model;
using RestWithASP_NET5Udemy.Model.Context;
using RestWithASP_NET5Udemy.Repository;
using System.Collections.Generic;
using System.Linq;

namespace RestWithASP_NET5Udemy.Business.Implementations
{
    public class BookBusinessmplementation : IBookBusiness
    {
        private readonly IRepository<Book> _repository;

        private readonly BookConverter _converter;

        public BookBusinessmplementation(IRepository<Book> repository)
        {
            _repository = repository;
            _converter = new BookConverter();

        }


        public List<BookVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }


        public BookVO FindByID(long id)
        {
            return _converter.Parse(_repository.FindByID(id));
        }



        public BookVO Create(BookVO book)
        {
            return _converter.Parse(_repository.Create(_converter.Parse(book)));
        }

        public BookVO Update(BookVO book)
        {
            return _converter.Parse(_repository.Update(_converter.Parse(book)));
        }


        public void Delete(long id)
        {
            _repository.Delete(id);

        }
    }
}
