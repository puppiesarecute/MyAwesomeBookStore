using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAwesomeBookStore.Repositories.Interfaces
{
    public interface IBookRepository<T>
    {
        IQueryable<T> AllObjects { get; }
        void Delete(T data);
        T Find(int id);
        void InsertOrUpdate(T data);
        void Save();
    }
}
