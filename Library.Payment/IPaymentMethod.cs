using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Payment
{
    public interface IPaymentMethod
    {
        bool PayForItem(string item, int price);
    }
}