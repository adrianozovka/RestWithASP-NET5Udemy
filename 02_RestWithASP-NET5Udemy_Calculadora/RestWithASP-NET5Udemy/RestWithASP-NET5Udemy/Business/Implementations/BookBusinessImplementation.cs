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

        public BookBusinessmplementation(IRepository<Book> repository)
        {
            _repository = repository;

        }


        public List<Book> FindAll()
        {
            return _repository.FindAll();
        }


        public Book FindByID(long id)
        {
            return _repository.FindByID(id);
        }



        public Book Create(Book book)
        {
            return _repository.Create(book); ;
        }

        public Book Update(Book book)
        {
            return _repository.Update(book);
        }


        public void Delete(long id)
        {
            _repository.Delete(id);

        }
    }
}
