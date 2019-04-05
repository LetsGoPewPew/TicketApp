using Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Persistency
{
    public interface IPersistMethod
    {
        void Create<T>(T data);
        void Read<T>(T data);
        void Update<T>(T data);
        void Delete<T>(T data);

    }
}