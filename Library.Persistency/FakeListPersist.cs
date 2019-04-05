using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Model;

namespace Library.Persistency
{
    class FakeListPersist : IPersistMethod
    {
        public void Create<T>(T data)
        {
            throw new NotImplementedException();
        }

        public void Delete<T>(T data)
        {
            throw new NotImplementedException();
        }

        public void Read<T>(T data)
        {
            throw new NotImplementedException();
        }

        public void Update<T>(T data)
        {
            throw new NotImplementedException();
        }
    }
}
