using System.Collections.Generic;

namespace TestAPI.Data
{
    public interface IBaseDa<T>
    {
        IEnumerable<T> List();
        T Get(int id);
        bool Update(T item);
        int Create(T item);
        bool Delete(int id);
    }
}
