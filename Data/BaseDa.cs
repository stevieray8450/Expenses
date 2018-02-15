using System;
using System.Collections.Generic;

namespace TestAPI.Data
{
    public abstract class BaseDa<T> : IBaseDa<T>
    {
        public virtual IEnumerable<T> List()
        {
            throw new NotImplementedException();
        }

        public virtual T Get(int id)
        {
            throw new NotImplementedException();
        }

        public virtual int Create(T item)
        {
            throw new NotImplementedException();
        }

        public virtual bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public virtual bool Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}
