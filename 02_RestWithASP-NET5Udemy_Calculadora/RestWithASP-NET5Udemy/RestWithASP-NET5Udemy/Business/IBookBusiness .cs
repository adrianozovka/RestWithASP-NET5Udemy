using RestWithASP_NET5Udemy.Model;
using System.Collections.Generic;

namespace RestWithASP_NET5Udemy.Business
{
    public interface IBookBusiness
    {

        Book Create(Book book);

        Book Update(Book book);

        List<Book> FindAll();

        Book FindByID(long id);

        void Delete(long id);

    }
}
