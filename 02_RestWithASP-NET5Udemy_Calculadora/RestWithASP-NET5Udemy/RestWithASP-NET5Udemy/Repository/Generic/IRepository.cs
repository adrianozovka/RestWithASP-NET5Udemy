using RestWithASP_NET5Udemy.Model;
using RestWithASP_NET5Udemy.Model.Base;
using System.Collections.Generic;

namespace RestWithASP_NET5Udemy.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {

        T Create(T item);

        T Update(T item);

        List<T> FindAll();

        T FindByID(long id);

        void Delete(long id);

        bool Exists(long id);

    }
}
