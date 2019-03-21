using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Verification
{
    public class BankId : IVerification
    {
        public bool Verify()
        {
            Console.WriteLine("BankID");
            return true;
        }
    }
}
