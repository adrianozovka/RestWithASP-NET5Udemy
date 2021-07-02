using Microsoft.EntityFrameworkCore;
using RestWithASP_NET5Udemy.Model.Base;
using RestWithASP_NET5Udemy.Model.Context;
using System.Collections.Generic;
using System.Linq;

namespace RestWithASP_NET5Udemy.Repository.Generic
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        private MySQLContext _context;

        private DbSet<T> dataset;

        public GenericRepository(MySQLContext context)
        {
            _context = context;
            dataset = _context.Set<T>();

        }


        public T Create(T item)
        {
            try
            {
                dataset.Add(item);
                _context.SaveChanges();
                return item;
            }
            catch
            {
                throw;
            }


        }

        public void Delete(long id)
        {
            var result = dataset.SingleOrDefault(p => p.Id.Equals(id));


            if (result != null)
            {
                try
                {
                    dataset.Remove(result);
                    _context.SaveChanges();
                }
                catch
                {
                    throw;
                }
            }

        }

        public bool Exists(long id)
        {
            return dataset.Any(p => p.Id.Equals(id));
        }

        public List<T> FindAll()
        {
            return dataset.ToList(); 
        }

        public T FindByID(long id)
        {
            return dataset.SingleOrDefault(p => p.Id.Equals(id));
        }

        public T Update(T item)
        {
            if (!Exists(item.Id)) { return null; }

            var result = dataset.SingleOrDefault(p => p.Id.Equals(item.Id));

            if (result != null)
            {

                try
                {
                    _context.Entry(result).CurrentValues.SetValues(item);
                    _context.SaveChanges();
                    return item;
                }
                catch
                {
                    throw;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
