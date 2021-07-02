using RestWithASP_NET5Udemy.Data.VO;
using System.Collections.Generic;

namespace RestWithASP_NET5Udemy.Business
{
    public interface IBookBusiness
    {

        BookVO Create(BookVO book);

        BookVO Update(BookVO book);

        List<BookVO> FindAll();

        BookVO FindByID(long id);

        void Delete(long id);

    }
}
