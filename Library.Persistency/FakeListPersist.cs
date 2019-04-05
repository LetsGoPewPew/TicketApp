using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Model;

namespace Library.Persistency
{
    public class FakeListPersist : IPersistMethod
    {
        public List<Customer> Customers = new List<Customer>();

        public void Create<T>(T data)
        {
            Console.WriteLine($"Create: {data}");
        }

        public void Delete<T>(T data)
        {
            Console.WriteLine($"Delete: {data}");
        }

        public void Read<T>(T data)
        {
            Console.WriteLine($"Read: {data}");
        }

        public void Update<T>(T data)
        {
            Console.WriteLine($"Update: {data}");
        }
    }
}
