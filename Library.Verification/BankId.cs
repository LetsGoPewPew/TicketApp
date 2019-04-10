using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Verification
{
    public class BankId : IVerificationMethod
    {
        public bool Verify()
        {
            return true;
        }

        public override string ToString()
        {
            return "BankID";
        }
    }
}
